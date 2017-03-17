using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverCityOS
{
  public interface MenuSection
    {
        void generate(MainWindow window);
        List<ucMenuItem> getItemList();
        string getName();
    }
}
