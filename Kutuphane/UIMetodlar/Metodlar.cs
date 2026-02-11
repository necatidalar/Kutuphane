using System.ComponentModel;

namespace Kutuphane.UI.UIMetodlar
{
    public static class Metodlar
    {
        public static void ComboDoldur<T>(this ComboBox comboBox, List<T> dataSource, string displayMember, string valueMember)
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.SelectedIndex = -1; // Hiçbir öğe seçilmemiş olarak başlat
        }

        public static void ComboItemDoldur<T>(ComboBox comboBox, ICollection<T> dataSource, string displayMember, string valueMember)
        {
            comboBox.Items.Clear();
            foreach (T item in dataSource)
            {
                comboBox.Items.Add(item);
            }

            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.SelectedIndex = -1; // Hiçbir öğe seçilmemiş olarak başlat
        }

        public static void gridDoldur<T>(BindingSource bindingSource, ICollection<T> dataList)
        {
            bindingSource.DataSource = new BindingList<T>(dataList.ToList());
            //foreach (var item in dataList)
            //    bindingSource.Add(item);
        }
    }
}
