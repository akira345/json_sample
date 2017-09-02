using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace json_sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ルートノード
            var root_node = new json_sample.RootObject();
            root_node.title = "Harry Potter and the Philosopher's Stone";
            root_node.author = "J.K. Rowling";
            root_node.tags = new List<string> { "novel", "story", "magic" };
            root_node.valiableTags = new List<object> { 123, false, "str" };
            root_node.intArray = new List<int> { 1, 2, 3, 4, 5 };
            root_node.floatArray = new List<double> { 1.2, 1.3, 1.4, 2.0 };
            root_node.date = "2016/11/29T12:34:56.000";
            root_node.year = "1997";

            //Hogeノード組み立て
            var hoge_node = new Hoge();
            hoge_node.stringField = "piyo";
            hoge_node.numField = 123;
            hoge_node.floatField = 20.315;
            hoge_node.boolField = false;

            //Hugaノード組み立て
            var huga_node = new JsonNodeHoge.Huga();
            huga_node.piyo = new List<string> { "orange",
                 "apple"};

            //ノード関連付け
            hoge_node.huga = huga_node;
            root_node.hoge = hoge_node;

            //出力
            var jsonserializersettings = new JsonSerializerSettings();
            //jsonconveet設定
            jsonserializersettings.NullValueHandling = NullValueHandling.Ignore; //nullは出さない
            jsonserializersettings.Formatting = Formatting.Indented; //JSON整形
            var jsonString = JsonConvert.SerializeObject(root_node, jsonserializersettings);
            MessageBox.Show(jsonString);

        }
    }
}
