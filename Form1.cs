/*
 * Michael Elder
 * CS311 Final Project  
 * This program checks which radio button is selected, 
 * 
 */

using System.Linq.Expressions;

namespace CS311_FinalProject_MRE
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {  
            UnitConverter();
            //runs the UnitConverter method when the button is clicked
            txt1.Clear();
            //clears the text in txt1 textbox when the button is clicked

        }//end calculate button

        private void UnitConverter()
        {
            
            
            double text, meterstofeet, feettometers, kilometerstomiles, milestokilometers, 
                  celsiustofahrenheight, fahrenheighttocelsius, kilogramtopounds,
                  poundstokilograms, gramstoounces, ouncestograms;//creating variables

            text = double.Parse(txt1.Text);
            //makes the text in the textbox a double 
            
            //extracting text from txt1 textbox, making it a double, and assigning it to text variable
              meterstofeet = text * 3.281;
              feettometers = text / 3.281;
              //conversion from feet to meters, feet to meters, and assigning them variables

              kilometerstomiles = text / 1.609;
              milestokilometers = text * 1.609;
              //conversion from kilometers to miles, miles to kilometers, and assigning them variables
              
              celsiustofahrenheight = (text * 1.8) + 32;
              fahrenheighttocelsius = (text - 32) / 1.8;
              //conversion from celsius to fahrenheight, fahrenheit to celsius, and assigning them variables
              
              kilogramtopounds = text * 2.205;
              poundstokilograms = text / 2.205;
              //conversion from kilograms to pounds, pounds to kilograms, and assigning them variables

              gramstoounces = text / 28.35;
              ouncestograms = text * 28.35;
              //conversion from grams to ounces, ounces to grams, and assigning them variables

            if (rdoMeterstoFeet.Checked)
                rtf1.Text = txt1.Text + " m = "+ meterstofeet.ToString("0.00") + " ft";
                //if radio button rdoMeterstoFeet is checked, meterstofeet variable gets  
                //printed in the rtf1 rich text box
            
            if (rdoFeettoMeeters.Checked)
                rtf1.Text = txt1.Text + " ft = " + feettometers.ToString("0.00") + " m";
                //if radio button rdoFeettoMeters is checked, feettometers variable gets  
                //printed in the rtf1 rich text box

            if (rdoKilometerstoMiles.Checked)
                rtf1.Text = txt1.Text + " km = " + kilometerstomiles.ToString("0.00") + " mi";
                //if radio button rdoKilometerstoMiles is checked, kilometerstomiles variable gets  
                //printed in the rtf1 rich text box

            if (rdoMilestoKilometers.Checked)
                rtf1.Text = txt1.Text + " mi = " + milestokilometers.ToString("0.00") + " km";
                //if radio button rdoMilestoKilometers is checked, milestokilometers variable gets  
                //printed in the rtf1 rich text box

            if (rdoCelciustoFahrenheit.Checked)
                rtf1.Text = txt1.Text + "°C = " + celsiustofahrenheight.ToString("0.00") + "°F";
                //if radio button rdoCelciustoFahrenheit is checked, celsiustofahrenheit variable gets  
                //printed in the rtf1 rich text box

            if (rdoFahrenheittoCelsius.Checked)
                rtf1.Text = txt1.Text + "°F = " + fahrenheighttocelsius.ToString("0.00") + "°C";
                //if radio button rdoFahrenheittoCelsius is checked, fahrenheittocelsius variable gets  
                //printed in the rtf1 rich text box

            if (rdoKilogramtoPounds.Checked)
                rtf1.Text = txt1.Text + " kgs = " + kilogramtopounds.ToString("0.00") + " lbs";
                //if radio button rdoKilogramstoPounds is checked, kilogramtopounds variable gets  
                //printed in the rtf1 rich text box

            if (rdoPoundstoKilogram.Checked)
                rtf1.Text = txt1.Text + " lbs = " + poundstokilograms.ToString("0.00") + " km";
                //if radio button rdoPoundstoKilograms is checked, poundstokilogram variable gets  
                //printed in the rtf1 rich text box
            if (rdoGramstoOunces.Checked)
                rtf1.Text = txt1.Text + " g = " + gramstoounces.ToString("0.00") + " oz";
                //if radio button rdoGramstoOunces is checked, gramstoounces variable gets  
                //printed in the rtf1 rich text box

            if (rdoOuncestoGrams.Checked)
                rtf1.Text = txt1.Text + " oz = " + ouncestograms.ToString("0.00") + " g";
                //if radio button rdoOuncestoGrams is checked, ouncestograms variable gets  
                //printed in the rtf1 rich text box          

        }//end UnitConverter method

        private void btn2_Click(object sender, EventArgs e)
        {
            rtf1.Text = "";
            //clears the rtf1 rich text box when clicked

        }//end clear button
    }//end class

}//end namespace