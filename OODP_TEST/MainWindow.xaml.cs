
using GraphQL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.Json;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQL.Client.Abstractions;

namespace OODP_TEST
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        public class testClass
        {
            public String test { get; set; }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var heroRequest = new GraphQLRequest
            {
                Query = @"query{test}"
            };
            var graph = new GraphQLHttpClient("http://3.121.231.129/oodp", new NewtonsoftJsonSerializer());


           
            var res = await graph.SendQueryAsync<testClass>(heroRequest);

            MessageBox.Show(res.Data.test);
        }
    }
}
