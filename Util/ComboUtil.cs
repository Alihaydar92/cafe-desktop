using Cafe.POJO;
using System;
using System.Windows.Forms;

namespace Cafe.Util
{
    class ComboUtil
    {
        public static void setComboItemByValue(ComboBox cb, int val)
        {
            Console.WriteLine(cb.Items.Count + " and " + val);
            int selIndex = -1;
            foreach (ComboItem itm in cb.Items)
            {
                Console.WriteLine(itm.Id + " and " + val);
                selIndex += 1;
                if (itm.Id == val)
                {

                    break;
                }
            }
            cb.SelectedIndex = selIndex;
        }

        public static int getSelectedComboValue(ComboBox cb)
        {
            int v_ret = 0;
            if (cb.SelectedIndex >= 0)
            {
                v_ret = (cb.SelectedItem as ComboItem).Id;
            }
            return v_ret;
        }
    }
}
