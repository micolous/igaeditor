// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Stetic {
    
    
    internal class Gui {
        
        public static void Build(object obj, System.Type type) {
            Stetic.Gui.Build(obj, type.FullName);
        }
        
        public static void Build(object obj, string id) {
            System.Collections.Hashtable bindings = new System.Collections.Hashtable();
            if ((id == "igaeditorgtk.MainForm")) {
                Gtk.Window cobj = ((Gtk.Window)(obj));
                // Widget igaeditorgtk.MainForm
                cobj.Title = "IGA Ad Cache Editor (GTK) by micolous";
                Gtk.UIManager w1 = new Gtk.UIManager();
                Gtk.ActionGroup w2 = new Gtk.ActionGroup("Default");
                Gtk.Action w3 = new Gtk.Action("Application", "_Application", null, null);
                w3.ShortLabel = "_Application";
                bindings["Application"] = w3;
                w2.Add(w3, null);
                Gtk.Action w4 = new Gtk.Action("ImportAdpack", "_Import Adpack", null, null);
                w4.ShortLabel = "_Import Adpack";
                bindings["ImportAdpack"] = w4;
                w2.Add(w4, null);
                Gtk.Action w5 = new Gtk.Action("ExportAdpack", "_Export Adpack", null, null);
                w5.ShortLabel = "_Export Adpack";
                bindings["ExportAdpack"] = w5;
                w2.Add(w5, null);
                Gtk.Action w6 = new Gtk.Action("", "-", null, null);
                w6.ShortLabel = "-";
                bindings[""] = w6;
                w2.Add(w6, null);
                Gtk.Action w7 = new Gtk.Action("Reload", "_Reload", null, "gtk-refresh");
                w7.ShortLabel = "_Reload";
                bindings["Reload"] = w7;
                w2.Add(w7, null);
                Gtk.Action w8 = new Gtk.Action("VaccumShrinkDatabase", "_Vaccum/Shrink Database", null, null);
                w8.ShortLabel = "_Vaccum/Shrink Database";
                bindings["VaccumShrinkDatabase"] = w8;
                w2.Add(w8, null);
                Gtk.Action w9 = new Gtk.Action("CloseDatabase", "_Close Database", null, "gtk-close");
                w9.ShortLabel = "_Close Database";
                bindings["CloseDatabase"] = w9;
                w2.Add(w9, null);
                Gtk.Action w10 = new Gtk.Action("Exit", "E_xit", null, "gtk-quit");
                w10.ShortLabel = "E_xit";
                bindings["Exit"] = w10;
                w2.Add(w10, null);
                Gtk.Action w11 = new Gtk.Action("Debug", "_Debug", null, null);
                w11.ShortLabel = "_Debug";
                bindings["Debug"] = w11;
                w2.Add(w11, null);
                Gtk.Action w12 = new Gtk.Action("Help", "_Help", null, null);
                w12.ShortLabel = "_Help";
                bindings["Help"] = w12;
                w2.Add(w12, null);
                Gtk.Action w13 = new Gtk.Action("About", "_About", null, "gtk-about");
                w13.ShortLabel = "_About";
                bindings["About"] = w13;
                w2.Add(w13, null);
                Gtk.Action w14 = new Gtk.Action("ExecuteSQL", "_Execute SQL", null, null);
                w14.ShortLabel = "_Execute SQL";
                bindings["ExecuteSQL"] = w14;
                w2.Add(w14, null);
                w1.InsertActionGroup(w2, 0);
                cobj.AddAccelGroup(w1.AccelGroup);
                cobj.WindowPosition = ((Gtk.WindowPosition)(4));
                cobj.Events = ((Gdk.EventMask)(0));
                cobj.Name = "igaeditorgtk.MainForm";
                // Container child igaeditorgtk.MainForm.Gtk.Container+ContainerChild
                Gtk.VBox w15 = new Gtk.VBox();
                w15.Events = ((Gdk.EventMask)(0));
                w15.Name = "vbox1";
                // Container child vbox1.Gtk.Box+BoxChild
                w1.AddUiFromString("<ui><menubar name='menubar1'><menu action='Application'><menuitem action='ImportAdpack'/><menuitem action='ExportAdpack'/><separator/><menuitem action='Reload'/><menuitem action='VaccumShrinkDatabase'/><menuitem action='CloseDatabase'/><separator/><menuitem action='Exit'/></menu><menu action='Debug'><menuitem action='ExecuteSQL'/></menu><menu action='Help'><menuitem action='About'/><separator/></menu></menubar></ui>");
                Gtk.MenuBar w16 = ((Gtk.MenuBar)(w1.GetWidget("/menubar1")));
                w16.Events = ((Gdk.EventMask)(0));
                w16.Name = "menubar1";
                bindings["menubar1"] = w16;
                w15.Add(w16);
                Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(w15[w16]));
                w17.Position = 0;
                w17.Expand = false;
                w17.Fill = false;
                // Container child vbox1.Gtk.Box+BoxChild
                Gtk.Frame w18 = new Gtk.Frame();
                w18.ShadowType = ((Gtk.ShadowType)(0));
                w18.LabelXalign = 0F;
                w18.Events = ((Gdk.EventMask)(0));
                w18.Name = "frame1";
                // Container child frame1.Gtk.Container+ContainerChild
                Gtk.Alignment w19 = new Gtk.Alignment(0F, 0F, 1F, 1F);
                w19.LeftPadding = ((uint)(12));
                w19.Events = ((Gdk.EventMask)(0));
                w19.Name = "GtkAlignment6";
                // Container child GtkAlignment6.Gtk.Container+ContainerChild
                Gtk.ScrolledWindow w20 = new Gtk.ScrolledWindow();
                w20.VscrollbarPolicy = ((Gtk.PolicyType)(1));
                w20.HscrollbarPolicy = ((Gtk.PolicyType)(2));
                w20.CanFocus = true;
                w20.Events = ((Gdk.EventMask)(0));
                w20.Name = "scrolledwindow1";
                // Container child scrolledwindow1.Gtk.Container+ContainerChild
                Gtk.TreeView w21 = new Gtk.TreeView();
                w21.EnableSearch = false;
                w21.CanFocus = true;
                w21.Events = ((Gdk.EventMask)(0));
                w21.Name = "RecordTreeView";
                bindings["RecordTreeView"] = w21;
                w20.Add(w21);
                bindings["scrolledwindow1"] = w20;
                w19.Add(w20);
                bindings["GtkAlignment6"] = w19;
                w18.Add(w19);
                Gtk.Label w25 = new Gtk.Label();
                w25.LabelProp = "<b>frame1</b>";
                w25.UseMarkup = true;
                w25.Events = ((Gdk.EventMask)(256));
                w25.Name = "DatabaseTitleLabel";
                bindings["DatabaseTitleLabel"] = w25;
                w18.LabelWidget = w25;
                bindings["frame1"] = w18;
                w15.Add(w18);
                Gtk.Box.BoxChild w26 = ((Gtk.Box.BoxChild)(w15[w18]));
                w26.Position = 1;
                // Container child vbox1.Gtk.Box+BoxChild
                Gtk.HBox w27 = new Gtk.HBox();
                w27.Events = ((Gdk.EventMask)(0));
                w27.Name = "hbox1";
                // Container child hbox1.Gtk.Box+BoxChild
                Gtk.Button w28 = new Gtk.Button();
                w28.UseStock = true;
                w28.UseUnderline = true;
                w28.CanFocus = true;
                w28.Events = ((Gdk.EventMask)(0));
                w28.Name = "AddRecordButton";
                w28.Label = "gtk-add";
                bindings["AddRecordButton"] = w28;
                w27.Add(w28);
                Gtk.Box.BoxChild w29 = ((Gtk.Box.BoxChild)(w27[w28]));
                w29.Position = 0;
                w29.Expand = false;
                w29.Fill = false;
                // Container child hbox1.Gtk.Box+BoxChild
                Gtk.Button w30 = new Gtk.Button();
                w30.UseStock = true;
                w30.UseUnderline = true;
                w30.CanFocus = true;
                w30.Events = ((Gdk.EventMask)(0));
                w30.Name = "EditRecordButton";
                w30.Label = "gtk-properties";
                bindings["EditRecordButton"] = w30;
                w27.Add(w30);
                Gtk.Box.BoxChild w31 = ((Gtk.Box.BoxChild)(w27[w30]));
                w31.Position = 1;
                w31.Expand = false;
                w31.Fill = false;
                // Container child hbox1.Gtk.Box+BoxChild
                Gtk.Button w32 = new Gtk.Button();
                w32.UseStock = true;
                w32.UseUnderline = true;
                w32.CanFocus = true;
                w32.Events = ((Gdk.EventMask)(0));
                w32.Name = "DeleteRecordButton";
                w32.Label = "gtk-remove";
                bindings["DeleteRecordButton"] = w32;
                w27.Add(w32);
                Gtk.Box.BoxChild w33 = ((Gtk.Box.BoxChild)(w27[w32]));
                w33.Position = 2;
                w33.Expand = false;
                w33.Fill = false;
                // Container child hbox1.Gtk.Box+BoxChild
                Gtk.Alignment w34 = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
                w34.Events = ((Gdk.EventMask)(0));
                w34.Name = "alignment4";
                bindings["alignment4"] = w34;
                w27.Add(w34);
                Gtk.Box.BoxChild w35 = ((Gtk.Box.BoxChild)(w27[w34]));
                w35.Position = 3;
                // Container child hbox1.Gtk.Box+BoxChild
                Gtk.Button w36 = new Gtk.Button();
                w36.UseUnderline = true;
                w36.CanFocus = true;
                w36.Events = ((Gdk.EventMask)(0));
                w36.Name = "PreviewImageButton";
                // Container child PreviewImageButton.Gtk.Container+ContainerChild
                Gtk.Alignment w37 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
                w37.Events = ((Gdk.EventMask)(0));
                w37.Name = "GtkAlignment";
                // Container child GtkAlignment.Gtk.Container+ContainerChild
                Gtk.HBox w38 = new Gtk.HBox();
                w38.Spacing = 2;
                w38.Events = ((Gdk.EventMask)(0));
                w38.Name = "GtkHBox";
                // Container child GtkHBox.Gtk.Container+ContainerChild
                Gtk.Image w39 = new Gtk.Image();
                w39.Pixbuf = Gtk.IconTheme.Default.LoadIcon("stock_zoom", 20, 0);
                w39.Events = ((Gdk.EventMask)(0));
                w39.Name = "image1";
                bindings["image1"] = w39;
                w38.Add(w39);
                // Container child GtkHBox.Gtk.Container+ContainerChild
                Gtk.Label w41 = new Gtk.Label();
                w41.LabelProp = "_Preview";
                w41.UseUnderline = true;
                w41.Events = ((Gdk.EventMask)(0));
                w41.Name = "GtkLabel";
                bindings["GtkLabel"] = w41;
                w38.Add(w41);
                bindings["GtkHBox"] = w38;
                w37.Add(w38);
                bindings["GtkAlignment"] = w37;
                w36.Add(w37);
                bindings["PreviewImageButton"] = w36;
                w27.Add(w36);
                Gtk.Box.BoxChild w45 = ((Gtk.Box.BoxChild)(w27[w36]));
                w45.Position = 4;
                w45.Expand = false;
                w45.Fill = false;
                // Container child hbox1.Gtk.Box+BoxChild
                Gtk.Button w46 = new Gtk.Button();
                w46.UseUnderline = true;
                w46.CanFocus = true;
                w46.Events = ((Gdk.EventMask)(0));
                w46.Name = "ImportImageButton";
                // Container child ImportImageButton.Gtk.Container+ContainerChild
                Gtk.Alignment w47 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
                w47.Events = ((Gdk.EventMask)(0));
                w47.Name = "GtkAlignment";
                // Container child GtkAlignment.Gtk.Container+ContainerChild
                Gtk.HBox w48 = new Gtk.HBox();
                w48.Spacing = 2;
                w48.Events = ((Gdk.EventMask)(0));
                w48.Name = "GtkHBox";
                // Container child GtkHBox.Gtk.Container+ContainerChild
                Gtk.Image w49 = new Gtk.Image();
                w49.Pixbuf = Gtk.IconTheme.Default.LoadIcon("gtk-open", 16, 0);
                w49.Events = ((Gdk.EventMask)(0));
                w49.Name = "image2";
                bindings["image2"] = w49;
                w48.Add(w49);
                // Container child GtkHBox.Gtk.Container+ContainerChild
                Gtk.Label w51 = new Gtk.Label();
                w51.LabelProp = "_Import";
                w51.UseUnderline = true;
                w51.Events = ((Gdk.EventMask)(0));
                w51.Name = "GtkLabel";
                bindings["GtkLabel"] = w51;
                w48.Add(w51);
                bindings["GtkHBox"] = w48;
                w47.Add(w48);
                bindings["GtkAlignment"] = w47;
                w46.Add(w47);
                bindings["ImportImageButton"] = w46;
                w27.Add(w46);
                Gtk.Box.BoxChild w55 = ((Gtk.Box.BoxChild)(w27[w46]));
                w55.Position = 5;
                w55.Expand = false;
                w55.Fill = false;
                // Container child hbox1.Gtk.Box+BoxChild
                Gtk.Button w56 = new Gtk.Button();
                w56.UseUnderline = true;
                w56.CanFocus = true;
                w56.Events = ((Gdk.EventMask)(0));
                w56.Name = "button16";
                // Container child button16.Gtk.Container+ContainerChild
                Gtk.Alignment w57 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
                w57.Events = ((Gdk.EventMask)(0));
                w57.Name = "GtkAlignment";
                // Container child GtkAlignment.Gtk.Container+ContainerChild
                Gtk.HBox w58 = new Gtk.HBox();
                w58.Spacing = 2;
                w58.Events = ((Gdk.EventMask)(0));
                w58.Name = "GtkHBox";
                // Container child GtkHBox.Gtk.Container+ContainerChild
                Gtk.Image w59 = new Gtk.Image();
                w59.Pixbuf = Gtk.IconTheme.Default.LoadIcon("gtk-save-as", 16, 0);
                w59.Events = ((Gdk.EventMask)(0));
                w59.Name = "image3";
                bindings["image3"] = w59;
                w58.Add(w59);
                // Container child GtkHBox.Gtk.Container+ContainerChild
                Gtk.Label w61 = new Gtk.Label();
                w61.LabelProp = "_Export";
                w61.UseUnderline = true;
                w61.Events = ((Gdk.EventMask)(0));
                w61.Name = "GtkLabel";
                bindings["GtkLabel"] = w61;
                w58.Add(w61);
                bindings["GtkHBox"] = w58;
                w57.Add(w58);
                bindings["GtkAlignment"] = w57;
                w56.Add(w57);
                bindings["button16"] = w56;
                w27.Add(w56);
                Gtk.Box.BoxChild w65 = ((Gtk.Box.BoxChild)(w27[w56]));
                w65.Position = 6;
                w65.Expand = false;
                w65.Fill = false;
                bindings["hbox1"] = w27;
                w15.Add(w27);
                Gtk.Box.BoxChild w66 = ((Gtk.Box.BoxChild)(w15[w27]));
                w66.Position = 2;
                w66.Expand = false;
                w66.Fill = false;
                bindings["vbox1"] = w15;
                cobj.Add(w15);
                cobj.DefaultWidth = 566;
                cobj.DefaultHeight = 300;
                bindings["igaeditorgtk.MainForm"] = cobj;
                w16.Show();
                w21.Show();
                w20.Show();
                w19.Show();
                w25.Show();
                w18.Show();
                w28.Show();
                w30.Show();
                w32.Show();
                w34.Show();
                w39.Show();
                w41.Show();
                w38.Show();
                w37.Show();
                w36.Show();
                w49.Show();
                w51.Show();
                w48.Show();
                w47.Show();
                w46.Show();
                w59.Show();
                w61.Show();
                w58.Show();
                w57.Show();
                w56.Show();
                w27.Show();
                w15.Show();
                cobj.Show();
                cobj.DeleteEvent += ((Gtk.DeleteEventHandler)(System.Delegate.CreateDelegate(typeof(Gtk.DeleteEventHandler), cobj, "OnDeleteEvent")));
                w7.Activated += ((System.EventHandler)(System.Delegate.CreateDelegate(typeof(System.EventHandler), cobj, "OnReloadActivated")));
                w8.Activated += ((System.EventHandler)(System.Delegate.CreateDelegate(typeof(System.EventHandler), cobj, "OnVaccumShrinkDatabaseActivated")));
                w9.Activated += ((System.EventHandler)(System.Delegate.CreateDelegate(typeof(System.EventHandler), cobj, "OnCloseDatabaseActivated")));
                w10.Activated += ((System.EventHandler)(System.Delegate.CreateDelegate(typeof(System.EventHandler), cobj, "OnExitActivated")));
                w36.Pressed += ((System.EventHandler)(System.Delegate.CreateDelegate(typeof(System.EventHandler), cobj, "OnPreviewImageButtonPressed")));
            }
            else {
                if ((id == "igaeditorgtk.OpenWindow")) {
                    Gtk.Window cobj = ((Gtk.Window)(obj));
                    // Widget igaeditorgtk.OpenWindow
                    cobj.Title = "IGA Ad Cache Editor (GTK) by micolous";
                    cobj.WindowPosition = ((Gtk.WindowPosition)(4));
                    cobj.Events = ((Gdk.EventMask)(0));
                    cobj.Name = "igaeditorgtk.OpenWindow";
                    // Container child igaeditorgtk.OpenWindow.Gtk.Container+ContainerChild
                    Gtk.VBox w1 = new Gtk.VBox();
                    w1.Events = ((Gdk.EventMask)(0));
                    w1.Name = "vbox1";
                    // Container child vbox1.Gtk.Box+BoxChild
                    Gtk.Label w2 = new Gtk.Label();
                    w2.LabelProp = "Welcome to IGA Ad Cache Editor.\n\nPlease select the ad cache file to open, otherwise known as \"icontent.cache\".";
                    w2.Wrap = true;
                    w2.Justify = ((Gtk.Justification)(3));
                    w2.Events = ((Gdk.EventMask)(0));
                    w2.Name = "label1";
                    bindings["label1"] = w2;
                    w1.Add(w2);
                    Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(w1[w2]));
                    w3.Position = 0;
                    w3.Expand = false;
                    w3.Fill = false;
                    // Container child vbox1.Gtk.Box+BoxChild
                    Gtk.FileChooserWidget w4 = new Gtk.FileChooserWidget(((Gtk.FileChooserAction)(0)));
                    w4.Events = ((Gdk.EventMask)(0));
                    w4.Name = "FileChooserControl";
                    bindings["FileChooserControl"] = w4;
                    w1.Add(w4);
                    Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(w1[w4]));
                    w5.Position = 1;
                    // Container child vbox1.Gtk.Box+BoxChild
                    Gtk.HBox w6 = new Gtk.HBox();
                    w6.Spacing = 2;
                    w6.BorderWidth = ((uint)(1));
                    w6.Events = ((Gdk.EventMask)(0));
                    w6.Name = "hbox2";
                    // Container child hbox2.Gtk.Box+BoxChild
                    Gtk.Alignment w7 = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
                    w7.Events = ((Gdk.EventMask)(0));
                    w7.Name = "alignment3";
                    bindings["alignment3"] = w7;
                    w6.Add(w7);
                    Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(w6[w7]));
                    w8.Position = 0;
                    // Container child hbox2.Gtk.Box+BoxChild
                    Gtk.Button w9 = new Gtk.Button();
                    w9.UseStock = true;
                    w9.UseUnderline = true;
                    w9.CanFocus = true;
                    w9.Events = ((Gdk.EventMask)(0));
                    w9.Name = "OpenDatabaseButton";
                    w9.Label = "gtk-open";
                    bindings["OpenDatabaseButton"] = w9;
                    w6.Add(w9);
                    Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(w6[w9]));
                    w10.Position = 1;
                    w10.Expand = false;
                    w10.Fill = false;
                    bindings["hbox2"] = w6;
                    w1.Add(w6);
                    Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(w1[w6]));
                    w11.Position = 2;
                    w11.Expand = false;
                    w11.Fill = false;
                    bindings["vbox1"] = w1;
                    cobj.Add(w1);
                    cobj.DefaultWidth = 611;
                    cobj.DefaultHeight = 407;
                    bindings["igaeditorgtk.OpenWindow"] = cobj;
                    w2.Show();
                    w4.Show();
                    w7.Show();
                    w9.Show();
                    w6.Show();
                    w1.Show();
                    cobj.Show();
                    cobj.DeleteEvent += ((Gtk.DeleteEventHandler)(System.Delegate.CreateDelegate(typeof(Gtk.DeleteEventHandler), cobj, "OnDeleteEvent")));
                    w4.FileActivated += ((System.EventHandler)(System.Delegate.CreateDelegate(typeof(System.EventHandler), cobj, "OnFileChooserControlFileActivated")));
                    w9.Clicked += ((System.EventHandler)(System.Delegate.CreateDelegate(typeof(System.EventHandler), cobj, "OnOpenDatabaseButtonClicked")));
                }
                else {
                    if ((id == "igaeditorgtk.SimpleMessageBox")) {
                        Gtk.Dialog cobj = ((Gtk.Dialog)(obj));
                        // Widget igaeditorgtk.SimpleMessageBox
                        cobj.Title = "IGA Ad Cache Editor";
                        cobj.WindowPosition = ((Gtk.WindowPosition)(4));
                        cobj.HasSeparator = false;
                        cobj.Events = ((Gdk.EventMask)(256));
                        cobj.Name = "igaeditorgtk.SimpleMessageBox";
                        // Internal child igaeditorgtk.SimpleMessageBox.VBox
                        Gtk.VBox w1 = cobj.VBox;
                        w1.BorderWidth = ((uint)(2));
                        w1.Events = ((Gdk.EventMask)(256));
                        w1.Name = "dialog_VBox";
                        // Container child dialog_VBox.Gtk.Box+BoxChild
                        Gtk.TextView w2 = new Gtk.TextView();
                        w2.WrapMode = ((Gtk.WrapMode)(2));
                        w2.Editable = false;
                        w2.Justification = ((Gtk.Justification)(3));
                        w2.CanFocus = true;
                        w2.Events = ((Gdk.EventMask)(0));
                        w2.Name = "MessageTextBox";
                        bindings["MessageTextBox"] = w2;
                        w1.Add(w2);
                        Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(w1[w2]));
                        w3.Position = 0;
                        bindings["dialog_VBox"] = w1;
                        // Internal child igaeditorgtk.SimpleMessageBox.ActionArea
                        Gtk.HButtonBox w4 = cobj.ActionArea;
                        w4.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
                        w4.Spacing = 10;
                        w4.BorderWidth = ((uint)(5));
                        w4.Events = ((Gdk.EventMask)(256));
                        w4.Name = "igaeditorgtk.SimpleMessageBox_ActionArea";
                        // Container child igaeditorgtk.SimpleMessageBox_ActionArea.Gtk.ButtonBox+ButtonBoxChild
                        Gtk.Button w5 = new Gtk.Button();
                        w5.UseStock = true;
                        w5.UseUnderline = true;
                        w5.CanFocus = true;
                        w5.Events = ((Gdk.EventMask)(0));
                        w5.Name = "OkayButton";
                        w5.CanDefault = true;
                        w5.Label = "gtk-ok";
                        bindings["OkayButton"] = w5;
                        cobj.AddActionWidget(w5, -7);
                        Gtk.ButtonBox.ButtonBoxChild w6 = ((Gtk.ButtonBox.ButtonBoxChild)(w4[w5]));
                        w6.Expand = false;
                        w6.Fill = false;
                        bindings["igaeditorgtk.SimpleMessageBox_ActionArea"] = w4;
                        cobj.DefaultWidth = 400;
                        cobj.DefaultHeight = 300;
                        bindings["igaeditorgtk.SimpleMessageBox"] = cobj;
                        w2.Show();
                        w1.Show();
                        w5.Show();
                        w4.Show();
                        cobj.Show();
                        w5.Pressed += ((System.EventHandler)(System.Delegate.CreateDelegate(typeof(System.EventHandler), cobj, "OnOkayButtonPressed")));
                    }
                }
            }
            System.Reflection.FieldInfo[] fields = obj.GetType().GetFields(((System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic) | System.Reflection.BindingFlags.Instance));
            for (int n = 0; (n < fields.Length); n = (n + 1)) {
                System.Reflection.FieldInfo field = fields[n];
                object widget = bindings[field.Name];
                if (((widget != null) && field.FieldType.IsInstanceOfType(widget))) {
                    field.SetValue(obj, widget);
                }
            }
        }
    }
    
    internal class ActionGroups {
        
        public static Gtk.ActionGroup GetActionGroup(System.Type type) {
            return Stetic.ActionGroups.GetActionGroup(type.FullName);
        }
        
        public static Gtk.ActionGroup GetActionGroup(string name) {
            return null;
        }
    }
}
