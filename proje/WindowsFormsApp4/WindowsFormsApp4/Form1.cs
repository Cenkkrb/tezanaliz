using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            bool value = false;
            try
            {
                doc.LoadFromFile(@""+textBox1.Text);
                value = false;
            }
            catch
            {
                MessageBox.Show("Geçerli bir dosya ismi giriniz. .docx uzantılı olmak zorunda");
                value = true;
            }

            if (!value)
            {
                List<FontInfo> HeadInfos = new List<FontInfo>();
                List<FontInfo> ParaInfos = new List<FontInfo>();
                List<PageInfo> PageInfos = new List<PageInfo>();
                List<UrlInfo> UrlInfos = new List<UrlInfo>();


                url.Text = "";
                paragraf.Text = "";
                sayfa.Text = "";
                baslik.Text = "";
                hsize.Text = "";
                psize.Text = "";
            

                HeadInfos.Clear();
                PageInfos.Clear();
                ParaInfos.Clear();
                UrlInfos.Clear();


                foreach (Section sec in doc.Sections)
                {
                   
                    PageInfo pageInfo = new PageInfo();
                    pageInfo.Left = sec.PageSetup.Margins.Left * 2.54f / 72f;
                    pageInfo.Right = sec.PageSetup.Margins.Right * 2.54f / 72f;
                    PageInfos.Add(pageInfo);

                    foreach (DocumentObject obj in sec.Body.ChildObjects)
                    {
                        if (obj.DocumentObjectType == DocumentObjectType.Paragraph)
                        {
                            Paragraph para = obj as Paragraph;
                            if (para.StyleName.Contains("Balk1"))   
                            {
                                foreach (DocumentObject paraObj in para.ChildObjects)
                                {
                                    if (paraObj.DocumentObjectType == DocumentObjectType.TextRange)
                                    {
                                        TextRange textRange = paraObj as TextRange;
                                        FontInfo head = new FontInfo();
                                        head.FontName = textRange.CharacterFormat.FontName;
                                        head.FontSize = textRange.CharacterFormat.FontSize;
                                        head.FontColor = textRange.CharacterFormat.TextColor;
                                        HeadInfos.Add(head);
                                    }
                                }
                            }
                            else if (!para.Text.Equals(""))           
                            {
                                foreach (DocumentObject paraObj in para.ChildObjects)
                                {
                                    if (paraObj.DocumentObjectType == DocumentObjectType.TextRange)
                                    {
                                        TextRange textRange = paraObj as TextRange;
                                        FontInfo parainfo = new FontInfo();
                                        parainfo.FontName = textRange.CharacterFormat.FontName;
                                        parainfo.FontSize = textRange.CharacterFormat.FontSize;
                                        parainfo.FontColor = textRange.CharacterFormat.TextColor;
                                        ParaInfos.Add(parainfo);

                                    }

                                    if (paraObj.DocumentObjectType == DocumentObjectType.Field)
                                    {
                                        Field field = paraObj as Field;
                                        if (field.Type.Equals(FieldType.FieldHyperlink))
                                        {
                                            UrlInfo urlInfo = new UrlInfo();
                                            urlInfo.Url = field.FieldText;
                                            UrlInfos.Add(urlInfo);
                                        }
                                    }
                                }
                            }

                        }
                    }
                }


                string pattern = "[a-zA-z]+://[^\\s]*";
                Regex rgx = new Regex(pattern);
                TextSelection[] textSelections = doc.FindAllPattern(rgx);

                if (textSelections != null)
                {
                foreach (TextSelection textSelection in textSelections)
                    {
                        TextRange textRange = textSelection.GetAsOneRange();
                        UrlInfo urlInfo = new UrlInfo();
                        urlInfo.Url = textRange.Text;
                        UrlInfos.Add(urlInfo);
                    }

                }
             

                foreach (UrlInfo urlInfo in UrlInfos)
                {
                    string url = urlInfo.Url;
                    HttpWebRequest req = null;
                    try
                    {
                        req = (HttpWebRequest)WebRequest.CreateDefault(new Uri(url));
                        req.Method = "HEAD";
                        req.Timeout = 10000;
                        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                        if (Convert.ToInt32(res.StatusCode).ToString().Equals("200"))
                        {
                            urlInfo.Message = "Url çalışıyor";
                        }
                    }
                    catch (Exception ex)
                    {
                        urlInfo.Message = ex.Message;
                    }
                    finally
                    {
                        if (req != null)
                        {
                            req.Abort();
                            req = null;
                        }
                    }
                }
                dataGridView1.DataSource = HeadInfos;
                dataGridView2.DataSource = ParaInfos;
                dataGridView3.DataSource = PageInfos;
                dataGridView4.DataSource = UrlInfos;


                bool urlValue = false;
                foreach (UrlInfo urlInfo in UrlInfos)
                {
                    if (!urlInfo.Message.Equals("Url çalışıyor"))
                    {
                        urlValue = true;
                    }
                }
                if (urlValue)
                {
                    url.Text = "Url tablosunda message bölümünde 'Url çalışıyor' mesajını vermeyen urlleri kontrol eediniz ";
                }

                bool paraValue = false;
                bool paraValueSize = false;
                foreach (FontInfo fontInfo in ParaInfos)
                {
                    if (!fontInfo.FontName.Equals("Times New Roman"))
                    {
                        paraValue = true;
                    }
                    if (!fontInfo.FontSize.Equals("12"))

                    {
                        paraValueSize = true;
                    }
                   
                }
                if (paraValue)
                {
                    paragraf.Text = "Paragraf tablosunda fontName bölümünde 'Times New Roman' mesajını göstermeyen kısımları düzeltiniz ve tekrar deneyiniz ";
                }
                if (paraValueSize)
                {
                    psize.Text = "Paragraf tablosunda fontSize bölümünde '12' mesajını göstermeyen kısımları düzeltiniz ve tekrar deneyiniz ";
                }
             
                bool headValue = false;
                bool headValueSize = false;
                foreach (FontInfo fontInfo in HeadInfos)
                {
                    if (!fontInfo.FontName.Equals("Times New Roman"))
                    {
                        headValue = true;
                    }
                    if (!fontInfo.FontSize.Equals("14"))
                    {
                        headValueSize = true;
                    }
                }
                if (headValue)
                {
                    baslik.Text = "Başlık tablosunda fontName bölümünde 'Times New Roman' mesajını göstermeyen kısımları düzeltiniz ve tekrar deneyiniz ";
                }
               if (headValueSize)
                {
                    hsize.Text = "Başlık tablosunda fontSize bölümünde '14' mesajını göstermeyen kısımları düzeltiniz ve tekrar deneyiniz ";
                }
            }


           
        }
    }

    public class FontInfo
    {
        public string FontName { get; set; }
        public float FontSize { get; set; }
        public Color FontColor { get; set; }
    }

    public class PageInfo
    {
        public float Left { get; set; }
        public float Right { get; set; }
    }

    public class UrlInfo
    {
        public string Url { get; set; }
        public string Message { get; set; }
    }

}
