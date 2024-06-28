using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCKDS.Helper
{
    public static class StringHelper
    {
        public static bool SaveFileToFolder(string path, string fileToSave)
        {
            bool isSave = false;
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
                {
                    file.WriteLine(fileToSave);
                }
                isSave = true;
            }
            catch (Exception ex)
            {

                return isSave;
            }

            return isSave;

            /*
            DataTable dt = ds.Tables[0];

            IList<Item> Items = MCKDS.Helper.DataHelper.ConvertToList<Item>(dt);

            string csv = String.Join(" , ", Items.Select(x => x.Items.ToString()).ToArray());
            */
        }
    }
}
