using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;

namespace youtube_dl_gui
{ 
    /// <summary>
    /// Veröffentlicht von Thomas Westrupp am 15.11.2007
    /// http://dotnet-snippets.de/snippet/ini-datei-klasse/660
    /// </summary>
    class CfgFile
    {
        private List<String> lines = new List<string>();    // Inhalt der Datei
        public long Count() => lines.Count;
        public string FileName { get; set; } = String.Empty;// Voller Pfad und Name der Datei
        public string getDirectory() => Path.GetDirectoryName(FileName);

        /// <summary>
        /// Gibt an, welche Zeichen als Kommentarbeginn
        /// gewertet werden sollen. Dabei wird das erste 
        /// Zeichen defaultmäßig für neue Kommentare
        /// verwendet.
        /// </summary>
        private String CommentCharacters = "#;";
        private String regCommentStr = "";                  // Regulärer Ausdruck für einen Kommentar in einer Zeile
        private Regex regEntry = null;                      // Regulärer Ausdruck für einen Eintrag
        private Regex regCaption = null;                    // Regulärer Ausdruck für einen Bereichskopf


        public CfgFile()                                    // Leerer Standard-Konstruktor
        {
            regCommentStr = @"(\s*[" + CommentCharacters + "](?<comment>.*))?";
            regEntry = new Regex(@"^[ \t]*(?<entry>([^=])+)=(?<value>([^=" + CommentCharacters + "])+)" + regCommentStr + "$");
            regCaption = new Regex(@"^[ \t]*(\[(?<caption>([^\]])+)\]){1}" + regCommentStr + "$");
        }

        /// <summary>
        /// Konstruktor, welcher sofort eine Datei einliest
        /// </summary>
        /// <param name="filename">Name der einzulesenden Datei</param>
        public CfgFile(string filename) : this()
        {
            if (!File.Exists(filename)) throw new IOException("File " + filename + "  not found");
            FileName = filename;
            using (StreamReader sr = new StreamReader(FileName, Encoding.Default))
                while (!sr.EndOfStream) lines.Add(sr.ReadLine().TrimEnd());
        }


        public Boolean Save()                           // Datei sichern
        {
            if (FileName == "") return false;
            try
            {
                using (StreamWriter sw = new StreamWriter(FileName, false, Encoding.Default))
                    foreach (String line in lines)
                        sw.WriteLine(line);
            }
            catch (IOException ex)
            {
                throw new IOException("Fehler beim Schreiben der Datei " + FileName, ex);
            }
            catch
            {
                throw new IOException("Fehler beim Schreiben der Datei " + FileName);
            }
            return true;
        }

        /// <summary>
        /// Sucht die Zeilennummer (nullbasiert) 
        /// eines gewünschten Eintrages
        /// </summary>
        /// <param name="Caption">Name des Bereiches</param>
        /// <param name="CaseSensitive">true = Gross-/Kleinschreibung beachten</param>
        /// <returns>Nummer der Zeile, sonst -1</returns>
        private int SearchCaptionLine(String Caption, Boolean CaseSensitive)
        {
            if (!CaseSensitive) Caption = Caption.ToLower();
            for (int i = 0; i < lines.Count; i++)
            {
                String line = lines[i].Trim();
                if (line == "") continue;
                if (!CaseSensitive) line = line.ToLower();
                // Erst den gewünschten Abschnitt suchen
                if (line == "[" + Caption + "]")
                    return i;
            }
            return -1;// Bereich nicht gefunden
        }

        /// <summary>
        /// Sucht die Zeilennummer (nullbasiert) 
        /// eines gewünschten Eintrages
        /// </summary>
        /// <param name="Caption">Name des Bereiches</param>
        /// <param name="Entry">Name des Eintrages</param>
        /// <param name="CaseSensitive">true = Gross-/Kleinschreibung beachten</param>
        /// <returns>Nummer der Zeile, sonst -1</returns>
        private int SearchEntryLine(String Caption, String Entry, Boolean CaseSensitive)
        {
            Caption = Caption.ToLower();
            if (!CaseSensitive) Entry = Entry.ToLower();
            int CaptionStart = SearchCaptionLine(Caption, false);
            if (CaptionStart < 0) return -1;
            for (int i = CaptionStart + 1; i < lines.Count; i++)
            {
                String line = lines[i].Trim();
                if (line == "") continue;
                if (!CaseSensitive) line = line.ToLower();
                if (line.StartsWith("["))
                    return -1;// Ende, wenn der nächste Abschnitt beginnt
                if (Regex.IsMatch(line, @"^[ \t]*[" + CommentCharacters + "]"))
                    continue; // Kommentar
                if (line.StartsWith(Entry + "="))
                    return i;// Eintrag gefunden
            }
            return -1;// Eintrag nicht gefunden
        }

        /// <summary>
        /// Kommentiert einen Wert aus
        /// </summary>
        /// <param name="Caption">Name des Bereiches</param>
        /// <param name="Entry">Name des Eintrages</param>
        /// <param name="CaseSensitive">true = Gross-/Kleinschreibung beachten</param>
        /// <returns>true = Eintrag gefunden und auskommentiert</returns>
        public Boolean commentValue(String Caption, String Entry, Boolean CaseSensitive)
        {
            int line = SearchEntryLine(Caption, Entry, CaseSensitive);
            if (line < 0) return false;
            lines[line] = CommentCharacters[0] + lines[line];
            return true;
        }

        /// <summary>
        /// Löscht einen Wert
        /// </summary>
        /// <param name="Caption">Name des Bereiches</param>
        /// <param name="Entry">Name des Eintrages</param>
        /// <param name="CaseSensitive">true = Gross-/Kleinschreibung beachten</param>
        /// <returns>true = Eintrag gefunden und gelöscht</returns>
        public Boolean deleteValue(String Caption, String Entry, Boolean CaseSensitive)
        {
            int line = SearchEntryLine(Caption, Entry, CaseSensitive);
            if (line < 0) return false;
            lines.RemoveAt(line);
            return true;
        }

        /// <summary>
        /// Liest den Wert eines Eintrages aus
        /// (Erweiterung: case sensitive)
        /// </summary>
        /// <param name="Caption">Name des Bereiches</param>
        /// <param name="Entry">Name des Eintrages</param>
        /// <param name="CaseSensitive">true = Gross-/Kleinschreibung beachten</param>
        /// <returns>Wert des Eintrags oder leer</returns>
        public String getValue(String Caption, String Entry, Boolean CaseSensitive)
        {
            int line = SearchEntryLine(Caption, Entry, CaseSensitive);
            if (line < 0) return String.Empty;
            int pos = lines[line].IndexOf("=");
            if (pos < 0) return String.Empty;
            return lines[line].Substring(pos + 1).Trim();
            // Evtl. noch abschliessende Kommentarbereiche entfernen
        }

        /// <summary>
        /// Setzt einen Wert in einem Bereich. Wenn der Wert
        /// (und der Bereich) noch nicht existiert, werden die
        /// entsprechenden Einträge erstellt.
        /// </summary>
        /// <param name="Caption">Name des Bereichs</param>
        /// <param name="Entry">name des Eintrags</param>
        /// <param name="Value">Wert des Eintrags</param>
        /// <param name="CaseSensitive">true = Gross-/Kleinschreibung beachten</param>
        /// <returns>true = Eintrag erfolgreich gesetzt</returns>
        public Boolean setValue(String Caption, String Entry, String Value, Boolean CaseSensitive)
        {
            Caption = Caption.ToLower();
            if (!CaseSensitive) Entry = Entry.ToLower();
            int lastCommentedFound = -1;
            int CaptionStart = SearchCaptionLine(Caption, false);
            if (CaptionStart < 0)
            {
                lines.Add("[" + Caption + "]");
                lines.Add(Entry + "=" + Value);
                return true;
            }
            int EntryLine = SearchEntryLine(Caption, Entry, CaseSensitive);
            for (int i = CaptionStart + 1; i < lines.Count; i++)
            {
                String line = lines[i].Trim();
                if (!CaseSensitive) line = line.ToLower();
                if (line == "") continue;
                // Ende, wenn der nächste Abschnitt beginnt
                if (line.StartsWith("["))
                {
                    lines.Insert(i, Entry + "=" + Value);
                    return true;
                }
                // Suche aukommentierte, aber gesuchte Einträge
                // (evtl. per Parameter bestimmen können?), falls
                // der Eintrag noch nicht existiert.
                if (EntryLine < 0)
                    if (Regex.IsMatch(line, @"^[ \t]*[" + CommentCharacters + "]"))
                    {
                        String tmpLine = line.Substring(1).Trim();
                        if (tmpLine.StartsWith(Entry + "="))
                        {
                            // Werte vergleichen, wenn gleich,
                            // nur Kommentarzeichen löschen
                            int pos = tmpLine.IndexOf("=");
                            if (pos > 0)
                            {
                                if (Value == tmpLine.Substring(pos + 1).Trim())
                                {
                                    lines[i] = tmpLine;
                                    return true;
                                }
                            }
                            lastCommentedFound = i;
                        }
                        continue;// Kommentar
                    }
                if (line.StartsWith(Entry + "="))
                {
                    lines[i] = Entry + "=" + Value;
                    return true;
                }
            }
            if (lastCommentedFound > 0)
                lines.Insert(lastCommentedFound + 1, Entry + "=" + Value);
            else
                lines.Insert(CaptionStart + 1, Entry + "=" + Value);
            return true;
        }

        /// <summary>
        /// Liest alle Einträge uns deren Werte eines Bereiches aus
        /// </summary>
        /// <param name="Caption">Name des Bereichs</param>
        /// <returns>Sortierte Liste mit Einträgen und Werten</returns>
        public SortedList<String, String> getCaption(String Caption)
        {
            SortedList<String, String> result = new SortedList<string, string>();
            Boolean CaptionFound = false;
            for (int i = 0; i < lines.Count; i++)
            {
                String line = lines[i].Trim();
                if (line == "") continue;
                // Erst den gewünschten Abschnitt suchen
                if (!CaptionFound)
                    if (line.ToLower() != "[" + Caption + "]") continue;
                    else
                    {
                        CaptionFound = true;
                        continue;
                    }
                // Ende, wenn der nächste Abschnitt beginnt
                if (line.StartsWith("[")) break;
                if (Regex.IsMatch(line, @"^[ \t]*[" + CommentCharacters + "]")) continue; // Kommentar
                int pos = line.IndexOf("=");
                if (pos < 0)
                    result.Add(line, "");
                else
                    result.Add(line.Substring(0, pos).Trim(), line.Substring(pos + 1).Trim());
            }
            return result;
        }

        /// <summary>
        /// Erstellt eine Liste aller enthaltenen Bereiche
        /// </summary>
        /// <returns>Liste mit gefundenen Bereichen</returns>
        public List<string> getAllCaptions()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < lines.Count; i++)
            {
                String line = lines[i];
                Match mCaption = regCaption.Match(lines[i]);
                if (mCaption.Success)
                    result.Add(mCaption.Groups["caption"].Value.Trim());
            }
            return result;
        }

        /// <summary>
        /// Exportiert sämtliche Bereiche und deren Werte
        /// in ein XML-Dokument
        /// </summary>
        /// <returns>XML-Dokument</returns>
        public XmlDocument exportToXml()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement(
                Path.GetFileNameWithoutExtension(this.FileName));
            doc.AppendChild(root);
            XmlElement Caption = null;
            for (int i = 0; i < lines.Count; i++)
            {
                Match mEntry = regEntry.Match(lines[i]);
                Match mCaption = regCaption.Match(lines[i]);
                if (mCaption.Success)
                {
                    Caption = doc.CreateElement(mCaption.Groups["caption"].Value.Trim());
                    root.AppendChild(Caption);
                    continue;
                }
                if (mEntry.Success)
                {
                    XmlElement xe = doc.CreateElement(mEntry.Groups["entry"].Value.Trim());
                    xe.InnerXml = mEntry.Groups["value"].Value.Trim();
                    if (Caption == null)
                        root.AppendChild(xe);
                    else
                        Caption.AppendChild(xe);
                }
            }
            return doc;
        }
    }
}
