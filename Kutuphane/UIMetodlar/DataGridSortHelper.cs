using System.ComponentModel;
using System.Reflection;

public static class DataGridSortHelper
{
    //public static void SortByColumn<T>(
    //    DataGridView grid,
    //    BindingList<T> bindingList,
    //    int columnIndex,
    //    ref bool asc
    //)
    //{
    //    string propertyName = grid.Columns[columnIndex].DataPropertyName;

    //    if (string.IsNullOrWhiteSpace(propertyName))
    //        return;

    //    PropertyInfo prop = typeof(T).GetProperty(propertyName);
    //    if (prop == null)
    //        return;

    //    IEnumerable<T> liste = bindingList.ToList();

    //    liste = asc
    //        ? liste.OrderBy(x => prop.GetValue(x, null))
    //        : liste.OrderByDescending(x => prop.GetValue(x, null));

    //    asc = !asc;

    //    bindingList.Clear();
    //    foreach (var item in liste)
    //        bindingList.Add(item);

    //    // Diğer kolonlardaki okları temizle
    //    foreach (DataGridViewColumn col in grid.Columns)
    //        col.HeaderCell.SortGlyphDirection = SortOrder.None;

    //    grid.Columns[columnIndex].HeaderCell.SortGlyphDirection =
    //        asc ? SortOrder.Descending : SortOrder.Ascending;
    //}
    public static void SortByColumn<T>(
        DataGridView grid,
        BindingList<T> bindingList,
        int columnIndex,
        Dictionary<string, bool> sortDirections
    )
    {
        string propertyName = grid.Columns[columnIndex].DataPropertyName;
        if (string.IsNullOrWhiteSpace(propertyName))
            return;

        PropertyInfo prop = typeof(T).GetProperty(propertyName);
        if (prop == null)
            return;

        if (!sortDirections.ContainsKey(propertyName))
            sortDirections[propertyName] = true;

        bool asc = sortDirections[propertyName];

        IEnumerable<T> liste = bindingList.ToList();
        liste = asc
            ? liste.OrderBy(x => prop.GetValue(x, null))
            : liste.OrderByDescending(x => prop.GetValue(x, null));

        sortDirections[propertyName] = !asc;

        bindingList.Clear();
        foreach (var item in liste)
            bindingList.Add(item);

        foreach (DataGridViewColumn col in grid.Columns)
            col.HeaderCell.SortGlyphDirection = SortOrder.None;

        grid.Columns[columnIndex].HeaderCell.SortGlyphDirection =
            asc ? SortOrder.Ascending : SortOrder.Descending;
    }
}
