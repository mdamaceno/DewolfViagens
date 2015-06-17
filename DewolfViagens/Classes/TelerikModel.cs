using Dewolf.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DewolfViagens.Classes
{
    public class TelerikModel
    {
        private static DewolfModel _instance = null;

        public static  DewolfModel DewolfModel
        {
            get
            {
                try
                {
                    if (_instance == null)
                    {
                        _instance = new DewolfModel("server=localhost;database=dewolfViagens;user id=root;password=aluno");
                    }

                    return _instance;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
    }
}
