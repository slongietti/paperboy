using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Volare.PaperBoy.ExternalModels.Olive
{
    public static class Publication
    {
        public class Date
        {
            public string timestamp { get; set; }
        }

        public class Details
        {
            public string location { get; set; }
            public string href { get; set; }
            public string publication { get; set; }
            public string publicationTitle { get; set; }
            public string name { get; set; }
            public string date { get; set; }
            public string language { get; set; }
            public bool rtl { get; set; }
            public string storageFormat { get; set; }
            public string version { get; set; }
            public Publish publish { get; set; }
            public string vm { get; set; }
            public string sk { get; set; }
            public string pdf { get; set; }
            public string modified { get; set; }
            public bool hasFootnotes { get; set; }
            public bool aips { get; set; }
            public int pagesCount { get; set; }
            public int defaultPageResolution { get; set; }
            public int previewResolution { get; set; }
            public Page_Img[] page_img { get; set; }
            public Page_Layer_Img[] page_layer_img { get; set; }
            public Meta[] meta { get; set; }
            public Section[] sections { get; set; }
            public int defaultPageWidth { get; set; }
            public int defaultPageHeight { get; set; }
            public Page[] pages { get; set; }
            public Toc[] toc { get; set; }
        }

        public class Publish
        {
            public string publisher { get; set; }
            public string xmdVer { get; set; }
            public string acrobatVer { get; set; }
        }

        public class Page_Img
        {
            public int res { get; set; }
            public bool def { get; set; }
            public string ext { get; set; }
        }

        public class Page_Layer_Img
        {
            public int res { get; set; }
            public string text { get; set; }
            public string pext { get; set; }
        }

        public class Meta
        {
            public string name { get; set; }
            public string[] val { get; set; }
        }

        public class Section
        {
            public string name { get; set; }
            public int[] pages { get; set; }
        }

        public class Page
        {
            public string l { get; set; }
            public bool sfr { get; set; }
            public string sk { get; set; }
            public En[] en { get; set; }
            public int w { get; set; }
            public int h { get; set; }
        }

        public class En
        {
            public string id { get; set; }
            public string n { get; set; }
            public string nc { get; set; }
            public string sk { get; set; }
            public int toc { get; set; }
            public int roi { get; set; }
            public int tid { get; set; }
            public string cid { get; set; }
            public Meta1[] meta { get; set; }
            public int wc { get; set; }
            public string t { get; set; }
            public string ep { get; set; }
            public string eap { get; set; }
            public Pr[] pr { get; set; }
            public string f { get; set; }
            public string vm { get; set; }
            public string pc { get; set; }
        }

        public class Meta1
        {
            public string name { get; set; }
            public string[] val { get; set; }
        }

        public class Pr
        {
            public string id { get; set; }
            public int[] box { get; set; }
            public int res { get; set; }
            public string ext { get; set; }
        }

        public class Toc
        {
            public int id { get; set; }
            public string t { get; set; }
            public string e { get; set; }
            public string p { get; set; }
            public int g { get; set; }
            public bool ip { get; set; }
            public bool _is { get; set; }
            public I[] i { get; set; }
        }

        public class I
        {
            public int id { get; set; }
            public string t { get; set; }
            public string e { get; set; }
            public string p { get; set; }
            public int g { get; set; }
            public bool ic { get; set; }
            public I1[] i { get; set; }
        }

        public class I1
        {
            public int id { get; set; }
            public string e { get; set; }
            public string p { get; set; }
            public int g { get; set; }
            public bool ic { get; set; }
            public string t { get; set; }
        }

    }
}