# How to refresh sorting dynamically when items source collection changes in .NET MAUI DataGrid SfDataGrid
This demo shows how to refresh sorting dynamically when the items source collection changes in the Syncfusion [.NET MAUI DataGrid](https://help.syncfusion.com/maui/datagrid/overview) `SfDataGrid`. By using this sample we can apply the sorting to the updated DatGrid automatically.

## Xaml
```
 <ContentPage.BindingContext>
    <local:OrderInfoRepository x:Name="viewModel" />
</ContentPage.BindingContext>

<Grid RowDefinitions="50,*">
    <Button Text="ChangeCollection"
         Clicked="Button_Clicked" />
    
    <syncfusion:SfDataGrid x:Name="dataGrid" Grid.Row="1" LiveDataUpdateMode="AllowDataShaping"
                        ItemsSource="{Binding OrderInfoCollection}">
        <syncfusion:SfDataGrid.Columns>
            <syncfusion:DataGridTextColumn MappingName="OrderID"
                                        HeaderText="Order ID" />
        </syncfusion:SfDataGrid.Columns>
        <syncfusion:SfDataGrid.SortColumnDescriptions>
            <syncfusion:SortColumnDescription ColumnName="OrderID"
                                           SortDirection="Descending" />
        </syncfusion:SfDataGrid.SortColumnDescriptions>
    </syncfusion:SfDataGrid>
</Grid>
```

   ## Xaml.cs
```
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        viewModel.OrderInfoCollection.Clear();
        viewModel.ChangeCollection();
    }
}
```
  ### OrderInfoRepository.cs
```
public void ChangeCollection()
{
    orderInfo.Add(new OrderInfo("2001", "Selena Alvarad", "Sweden", "BERGS", "London"));
    orderInfo.Add(new OrderInfo("2002", "Sandra Altamirano", "Mexico", "ANATR", "Mexico D.F."));
    orderInfo.Add(new OrderInfo("2003", "Oscar Alpuerto", "France", "BLONP", "Strasbourg"));
    orderInfo.Add(new OrderInfo("2004", "Cecil Allison", "UK", "AROUT", "London"));
    orderInfo.Add(new OrderInfo("2005", "Tim Adams", "Germany", "ALFKI", "Berlin"));
    orderInfo.Add(new OrderInfo("2006", "Michael Allen", "Canada", "BOTTM", "Lenny Lin"));
    orderInfo.Add(new OrderInfo("2007", "Andrew Fuller", "France", "BLONP", "Strasbourg"));
    orderInfo.Add(new OrderInfo("2008", "Martin King", "Spain", "BOLID", "Madrid"));
    orderInfo.Add(new OrderInfo("2009", "Phyllis Allen", "France", "BONAP", "Marsiella"));
    orderInfo.Add(new OrderInfo("2010", "John Carter", "UK", "AROUT", "London"));
    orderInfo.Add(new OrderInfo("2011", "Marvin Allen", "Sweden", "BERGS", "London"));
    orderInfo.Add(new OrderInfo("2012", "Anne Wilson", "Germany", "BLAUS", "Mannheim"));
    orderInfo.Add(new OrderInfo("2013", "Sean Jacobson", "Mexico", "ANTON", "Mexico D.F."));
    orderInfo.Add(new OrderInfo("2014", "Gina Irene", "UK", "AROUT", "London"));
}
```

Executing the code example above yields the following output

<img src="https://github.com/user-attachments/assets/94730d54-b826-4831-bef3-ae2148a8489d" width=800/>

View sample in [GitHub](https://github.com/SyncfusionExamples/How-to-refresh-sorting-when-items-source-collection-changes-in-.NET-MAUI-DataGrid-SfDataGrid/tree/Refresh_Sorting)

 Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).

### Conclusion
I hope you enjoyed learning about How to implement select all checkbox column in SfDataGrid.

You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.

If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums),[Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!
