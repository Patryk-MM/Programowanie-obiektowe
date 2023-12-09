using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Zad_03 {
    internal class Data {
        public DateTime DateTime;

        public string CurrentDate() {
            return DateTime.Now.ToString();
        }

        public string DateForward() {
            return DateTime.Now.AddDays(7).ToString();
        }

        public string DateBackward() {
            return DateTime.Now.AddDays(-7).ToString();
        }
    }
}
