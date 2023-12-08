using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGT_NTP_8Ara_1
{
    class Ogrenci
    {
        string ad;
        int okulNo;

        public string AD
        {
            get { 
                return ad; 
            } 
            set { 
                ad = value;
            }
        }

        public int OKULNO
        {
            get { 
                return okulNo;
            }
        }

        public void tarihNe() {
            MessageBox.Show("8Aralık2023");
        }














    }
}
