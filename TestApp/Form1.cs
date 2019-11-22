using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IronPython.Integration;

namespace TestApp
{
    public partial class Form1 : Form
    {
        IntegrationTests myIntegrationTests = new IntegrationTests();

        public Form1()
        {
            InitializeComponent();
        }

        public string GetAString()
        {
            return "I'm a string from a host method";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(myIntegrationTests.SimpleExecutionTest().ToString());
            listBox1.Items.Add(myIntegrationTests.PassingParameterTest().ToString());

            listBox1.Items.Add(myIntegrationTests.MixingPythonWithCSharpMethodTest().ToString());
            listBox1.Items.Add(myIntegrationTests.InstantiatePythonClassTest().ToString());
            listBox1.Items.Add(myIntegrationTests.ImportingNamespacesTest().ToString());
            listBox1.Items.Add(myIntegrationTests.ReturningGenericListFromPythonTest().ToString());
            listBox1.Items.Add(myIntegrationTests.GenerateDotNetAssemblyFromPythonScriptTest().ToString());
            listBox1.Items.Add(myIntegrationTests.ReturnDateTimeHandlingTest().ToString());
            listBox1.Items.Add(myIntegrationTests.InstantiatePythonViaConfigurationFileTest().ToString());
            listBox1.Items.Add(myIntegrationTests.PassingParameterTest().ToString());
            listBox1.Items.Add(myIntegrationTests.PassingParameterTest2().ToString());

            listBox1.Items.Add(myIntegrationTests.ReferenceHostMethods("test", this).ToString());
            
        }
    }
}
