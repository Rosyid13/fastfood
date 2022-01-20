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

namespace FastFood
{
    public partial class MenuMakan : UserControl
    {
        public MenuMakan()
        {
            InitializeComponent();
        }

        private void btnReadMore1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Calzone is a food that is shaped like a jumbo size pastel," + "\n" +
                "is an authentic Italian confectionery, still a variant of Pizza ." +
                "It is called a Pizza variant because the crust dough for Calzone tends " +
                "to be very similar to the crust dough on pizza." +
                "Calzone fillings and sauces are usually the same as pizza fillings and sauces. " +
                "The difference is, the pizza is baked open, while the calzone is folded or bent so that the topping is on the inside" + "\n\n" +
                "Ingredients :\n" + 
                "1. Ricotta\n" +
                "2. Mozzarella\n" +
                "3. Salami/ham\n" +
                "4. Parmesan/pecorino" + "\n\n" +
                "Variation :\n" +
                "Tomatoes, Provolone, Anchovies, Oil, Onions, Chards, Minced Meat, Sauces, Fish, Cabbage", "Calzone Pizza");
        }

        private void btnReadMore2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Chicago-style pizza is pizza prepared according to several different styles developed in Chicago," +
                "widely referred to simply as deep dish pizza due to its cooking style. The pan in which it is baked gives the pizza " +
                "its characteristically high edge which provides ample space for large amounts of cheese and a chunky tomato sauce." +
                "Chicago-style pizza may be prepared in deep-dish style and as a stuffed pizza." + "\n\n" +
                "Ingredients :\n" +
                "1. Pizza Dough\n" +
                "2. Tomato Sauce\n" +
                "3. Cheese" + "\n\n" +
                "Variation :\n" +
                "Sausage, Pepperoni, Onions, Mushrooms, etc", "Chicago Style Pizza");
        }

        private void btnReadMore3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Greek Pizza, In the cuisine of the United States," +
                "Greek pizza is a style of pizza crust and preparation where the pizza is proofed and cooked in a metal pan " +
                "rather than stretched to order and baked on the floor of the pizza oven.[1] A shallow pan is used, " +
                "unlike the deep pans used in Sicilian, Chicago, or Detroit-styled pizzas. Its crust is typically spongy, airy, and light," +
                "like focaccia but not as thick.[2] The crust is also rather oily, due to the coating of oil applied to the pan during preparation." +
                "In the United States, Greek - style pizza is common in New England and parts of eastern New York State.\n\n" +
                "Ingredients :\n" +
                "1. Pizza Dough\n" +
                "2. Cheese" + "\n" +
                "3. Tomato Sauce\n", "Greek Pizza");
        }
    }
}
