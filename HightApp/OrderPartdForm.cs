using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace HightApp
{
    public partial class OrderPartdForm : Form
    {
        public OrderPartdForm() { }
        //{
        //    InitializeComponent();
        //    Word._Application application;
        //    Word._Document document;

        //    Object missingObj = System.Reflection.Missing.Value;
        //    Object trueObj = true;
        //    Object falseObj = false;

        //    //создаем обьект приложения word
        //    application = new Word.Application();
        //    // создаем путь к файлу
        //    Object templatePathObj = "F:\\dox.docx"; 

        //    // если вылетим не этом этапе, приложение останется открытым
        //    try
        //    {
        //        document = application.Documents.Add(ref templatePathObj, ref missingObj, ref missingObj, ref missingObj);
        //    }
        //    catch (Exception error)
        //    {
        //        document = application.Documents.Add(ref templatePathObj, ref missingObj, ref missingObj, ref missingObj);

        //        document.Close(ref falseObj, ref missingObj, ref missingObj);
        //        application.Quit(ref missingObj, ref missingObj, ref missingObj);
        //        document = null;
        //        application = null;
        //        throw error;
        //    }
            
        //    application.Visible = true;


        //    // обьектные строки для Word
        //    object strToFindObj;// = strToFind;
        //    object replaceStrObj;// = replaceStr;
        //    // диапазон документа Word
        //    Word.Range wordRange;
        //    //тип поиска и замены
        //    object replaceTypeObj;
        //    replaceTypeObj = Word.WdReplace.wdReplaceAll;
        //    // обходим все разделы документа
        //    for (int i = 1; i <= document.Sections.Count; i++)
        //    {
        //        // берем всю секцию диапазоном
        //        wordRange = document.Sections[i].Range;

        //        /*
        //        Обходим редкий глюк в Find, ПРИЗНАННЫЙ MICROSOFT, метод Execute на некоторых машинах вылетает с ошибкой "Заглушке переданы неправильные данные / Stub received bad data"  Подробности: http://support.microsoft.com/default.aspx?scid=kb;en-us;313104
        //        // выполняем метод поиска и  замены обьекта диапазона ворд
        //        wordRange.Find.Execute(ref strToFindObj, ref wordMissing, ref wordMissing, ref wordMissing, ref wordMissing, ref wordMissing, ref wordMissing, ref wordMissing, ref wordMissing, ref replaceStrObj, ref replaceTypeObj, ref wordMissing, ref wordMissing, ref wordMissing, ref wordMissing);
        //        */

        //        Word.Find wordFindObj = wordRange.Find;
        //        object[] wordFindParameters = new object[15] { strToFindObj, missingObj, missingObj, missingObj, missingObj, missingObj, missingObj, missingObj, missingObj, replaceStrObj, replaceTypeObj, missingObj, missingObj, missingObj, missingObj };

        //        wordFindObj.GetType().InvokeMember("Execute", BindingFlags.InvokeMethod, null, wordFindObj, wordFindParameters);
        //    }

        //    // Microsoft.Office.Interop.Word.Application winword =
        //    // new Microsoft.Office.Interop.Word.Application();
        //}
    }
}
