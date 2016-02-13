using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualBookScanV2
{
    class BookProject
    {
        private String m_stWorkingFolderName;
        private String m_stBookName;
        private bool m_bReversed;
        private bool m_bDirty;
        private ArrayList m_stImageFileNames;

        public String WorkingFolderName
        {
            get { return m_stWorkingFolderName; }
        }

        public String BookName
        {
            get { return m_stBookName.Length == 0 ? "(Noname)" : m_stBookName; }
        }

        public bool Reversed
        {
            get { return m_bReversed; }
        }

        public ArrayList ImageFileNames
        {
            get { return m_stImageFileNames; }
        }

        public BookProject()
        {
            Init();
        }

        public void Init()
        {
            m_stWorkingFolderName = "";
            m_stBookName = "";
            m_bReversed = false;
            m_bDirty = false;
            m_stImageFileNames = new ArrayList();
        }
        
        public bool QuerySave()
        {
            if (m_bDirty)
            {
                // return false when cancel
                DialogResult ret = MessageBox.Show("The book project is modified, Save It?", "Warning", MessageBoxButtons.YesNoCancel);
                switch (ret)
                {
                    case DialogResult.Yes:
                        Save();
                        break;
                    case DialogResult.No:
                        // don't save
                        break;
                    case DialogResult.Cancel:
                        return false;
                }
            }
            return true;
        }

        public void New(String stWorkingFolderName, String stBookName, bool bReversed)
        {
            m_stWorkingFolderName = stWorkingFolderName;
            m_stBookName = stBookName;
            m_bReversed = bReversed;
            m_bDirty = true;
            m_stImageFileNames = new ArrayList();
        }

        public void Close()
        {
            m_stWorkingFolderName = "";
            m_stBookName = "";
            m_bReversed = false;
            m_bDirty = false;
        }

        public void Load(String stWorkingFolderName, String stBookName)
        {
            try
            {
                m_stWorkingFolderName = stWorkingFolderName;
                m_stBookName = stBookName;
                String text = System.IO.File.ReadAllText(stWorkingFolderName + "\\" + stBookName);

                /* text = "0\n"
                "C:\\MSX\\Labels\\octo_label.png\n"
                "C:\\MSX\\Labels\\op4 sound card label copy.png\n"
                };";
                
                string[] items = text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                int count = 0;
                foreach (String item in items)
                {
                    if (count == 0)
                    {
                        m_bReversed = bool.Parse(item);
                    }
                    else
                    {
                        m_stImageFileNames[count] = item;
                    }
                    count++;
                }*/

                m_bReversed = bool.Parse(text);

                m_bDirty = false;
            }
            catch
            {
                MessageBox.Show("Load Failed", "Warning");
            }
        }

        public void Save()
        {
            try
            {
                String[] lines = { m_bReversed == false ? "0" : "1" };
                System.IO.File.WriteAllLines(m_stWorkingFolderName + "\\" + m_stBookName, lines);
                m_bDirty = false;
            }
            catch
            {
                MessageBox.Show("Save Failed", "Warning");
            }
        }

        public void SaveAs(String stWorkingFolderName, String stBookName)
        {
            m_stWorkingFolderName = stWorkingFolderName;
            m_stBookName = stBookName;
            Save();
        }
    }
}
