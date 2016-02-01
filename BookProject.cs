using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualBookScanV2
{
    class BookProject
    {
        public String m_stWorkingFolder;
        public String m_stBookName;
        public bool m_bReverse;

        private bool m_bDirty;
        public bool IsDirty
        {
            get { return m_bDirty; }
        }

        public BookProject()
        {
            Init();
        }

        public void Init()
        {
            m_bDirty = false;
            m_stWorkingFolder = "";
            m_stBookName = "";
            m_bReverse = false;
        }

        public void CheckSave()
        {
            if (m_bDirty)
            {
                if (MessageBox.Show("Save It?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Save();
                }
            }
        }

        public void New(String stWorkingFolder, String stBookName)
        {
            CheckSave();
            
            m_stWorkingFolder = stWorkingFolder;
            m_stBookName = stBookName;
            m_bDirty = false;
        }

        public void Load(String stWorkingFolder, String stBookName)
        {
            CheckSave();

            try
            {
                String fileName = String.Format("{0}\\{1}.book", m_stWorkingFolder, m_stBookName);
                String text = System.IO.File.ReadAllText(fileName);

                m_stWorkingFolder = stWorkingFolder;
                m_stBookName = stBookName;
                /* string myString = "10, 12";
                string[] stringValues = myString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int a = Int32.Parse(stringValues[0]);
                int b = Int32.Parse(stringValues[1]); */
                m_bReverse = (int.Parse(text) == 0) ? false : true;
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
                String fileName = String.Format("{0}\\{1}.book", m_stWorkingFolder, m_stBookName);
                String[] lines = { m_bReverse.ToString() };
                System.IO.File.WriteAllLines(fileName, lines);
                m_bDirty = false;
            }
            catch
            {
                MessageBox.Show("Save Failed", "Warning");
            }
        }
    }
}
