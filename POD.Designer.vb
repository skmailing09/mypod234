Partial Class POD
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim Barcode1 As Telerik.Reporting.Barcode
        Dim Barcode2 As Telerik.Reporting.Barcode
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POD))
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup4 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.List1 = New Telerik.Reporting.List()
        Me.Panel3 = New Telerik.Reporting.Panel()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.TextBox41 = New Telerik.Reporting.TextBox()
        Me.TextBox34 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.TextBox45 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource2 = New Telerik.Reporting.SqlDataSource()
        Me.List2 = New Telerik.Reporting.List()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.TextBox40 = New Telerik.Reporting.TextBox()
        Me.TextBox42 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox50 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Barcode1 = New Telerik.Reporting.Barcode()
        Barcode2 = New Telerik.Reporting.Barcode()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Barcode1
        '
        Barcode1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.9101409912109375R), Telerik.Reporting.Drawing.Unit.Inch(1.8997629880905151R))
        Barcode1.Name = "Barcode1"
        Barcode1.ShowText = True
        Barcode1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6898584365844727R), Telerik.Reporting.Drawing.Unit.Inch(0.50031661987304688R))
        Barcode1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Barcode1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Barcode1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Barcode1.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Barcode1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Barcode1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Barcode1.Value = "= Fields.SUB_NO"
        '
        'Barcode2
        '
        Barcode2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.91029870510101318R), Telerik.Reporting.Drawing.Unit.Inch(1.8999214172363281R))
        Barcode2.Name = "Barcode2"
        Barcode2.ShowText = True
        Barcode2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6893467903137207R), Telerik.Reporting.Drawing.Unit.Inch(0.50031661987304688R))
        Barcode2.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Barcode2.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Barcode2.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Barcode2.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Barcode2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Barcode2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Barcode2.Value = "= Fields.SUB_NO"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(3.6000001430511475R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.List1, Me.List2})
        Me.detail.Name = "detail"
        Me.detail.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.detail.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.detail.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.detail.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        '
        'List1
        '
        Me.List1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(3.5999999046325684R)))
        Me.List1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(3.5998818874359131R)))
        Me.List1.Body.SetCellContent(0, 0, Me.Panel3)
        TableGroup1.Name = "ColumnGroup"
        Me.List1.ColumnGroups.Add(TableGroup1)
        Me.List1.DataSource = Me.SqlDataSource2
        Me.List1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel3})
        Me.List1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.000078717865108046681R))
        Me.List1.Name = "List1"
        TableGroup2.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup2.Name = "DetailGroup"
        Me.List1.RowGroups.Add(TableGroup2)
        Me.List1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.5999999046325684R), Telerik.Reporting.Drawing.Unit.Inch(3.5998818874359131R))
        Me.List1.Style.LineColor = System.Drawing.Color.Transparent
        '
        'Panel3
        '
        Me.Panel3.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox2, Me.TextBox13, Me.TextBox23, Me.TextBox26, Me.TextBox27, Me.TextBox28, Me.TextBox29, Me.TextBox35, Me.TextBox15, Me.TextBox37, Me.TextBox38, Me.TextBox39, Me.TextBox41, Barcode2, Me.TextBox34, Me.TextBox5, Me.TextBox22, Me.TextBox30, Me.TextBox31, Me.TextBox32, Me.TextBox33, Me.TextBox45})
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.5999999046325684R), Telerik.Reporting.Drawing.Unit.Inch(3.5998818874359131R))
        Me.Panel3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = False
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.00027561187744140625R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.5996849536895752R), Telerik.Reporting.Drawing.Unit.Inch(0.3999999463558197R))
        Me.TextBox2.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox2.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox2.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox2.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox2.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox2.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox2.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox2.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "= Fields.Comapny_Name"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.40011799335479736R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3124213218688965R), Telerik.Reporting.Drawing.Unit.Inch(0.19988203048706055R))
        Me.TextBox13.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox13.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox13.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox13.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox13.Style.Font.Bold = True
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox13.Value = "Mob. : 8080770754"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.3125R), Telerik.Reporting.Drawing.Unit.Inch(0.40011849999427795R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2873427867889404R), Telerik.Reporting.Drawing.Unit.Inch(0.19988203048706055R))
        Me.TextBox23.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox23.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox23.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox23.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox23.Style.Font.Bold = True
        Me.TextBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox23.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox23.Value = "Website:-www.skmailing.com"
        '
        'TextBox26
        '
        Me.TextBox26.CanGrow = False
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.80962181091308594R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89960622787475586R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox26.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox26.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox26.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox26.Value = "Consignee :"
        '
        'TextBox27
        '
        Me.TextBox27.CanGrow = False
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.91029864549636841R), Telerik.Reporting.Drawing.Unit.Inch(0.80007952451705933R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6895442008972168R), Telerik.Reporting.Drawing.Unit.Inch(0.20954231917858124R))
        Me.TextBox27.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox27.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox27.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox27.Value = "= Fields.NAME"
        '
        'TextBox28
        '
        Me.TextBox28.CanGrow = False
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0097006559371948R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89960628747940063R), Telerik.Reporting.Drawing.Unit.Inch(0.69006311893463135R))
        Me.TextBox28.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox28.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox28.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox28.Value = "Address : "
        '
        'TextBox29
        '
        Me.TextBox29.CanGrow = False
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.8996850848197937R), Telerik.Reporting.Drawing.Unit.Inch(1.0097006559371948R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6999607086181641R), Telerik.Reporting.Drawing.Unit.Inch(0.68986594676971436R))
        Me.TextBox29.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox29.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox29.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox29.Value = "= Fields.ADD_1 + "","" + Fields.ADD_2 + "","" + Fields.ADD_3 + "","" + Fields.STATE + """ & _
    ","" + Fields.PIN"
        '
        'TextBox35
        '
        Me.TextBox35.CanGrow = False
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.00023619334388058633R), Telerik.Reporting.Drawing.Unit.Inch(2.4003169536590576R))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.900000274181366R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox35.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox35.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox35.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox35.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox35.Value = "Reciever Name :"
        '
        'TextBox15
        '
        Me.TextBox15.CanGrow = False
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(2.6003959178924561R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89996081590652466R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox15.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox15.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox15.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox15.Value = "Signature :"
        '
        'TextBox37
        '
        Me.TextBox37.CanGrow = False
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.00027561187744140625R), Telerik.Reporting.Drawing.Unit.Inch(2.8004748821258545R))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89996081590652466R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox37.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox37.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox37.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox37.Value = "Dely. Date :"
        '
        'TextBox38
        '
        Me.TextBox38.CanGrow = False
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.00027561187744140625R), Telerik.Reporting.Drawing.Unit.Inch(3.0005538463592529R))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.900000274181366R), Telerik.Reporting.Drawing.Unit.Inch(0.19932988286018372R))
        Me.TextBox38.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox38.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox38.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox38.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox38.Value = "Tel No. :"
        '
        'TextBox39
        '
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(3.1999626159667969R))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.5999996662139893R), Telerik.Reporting.Drawing.Unit.Inch(0.39988008141517639R))
        Me.TextBox39.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox39.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox39.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox39.Value = ""
        '
        'TextBox41
        '
        Me.TextBox41.CanGrow = False
        Me.TextBox41.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.90035468339920044R), Telerik.Reporting.Drawing.Unit.Inch(2.4003169536590576R))
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6996450424194336R), Telerik.Reporting.Drawing.Unit.Inch(0.60015791654586792R))
        Me.TextBox41.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox41.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox41.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox41.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox41.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox41.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox41.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox41.Value = ""
        '
        'TextBox34
        '
        Me.TextBox34.CanGrow = False
        Me.TextBox34.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(1.8999214172363281R))
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.90027588605880737R), Telerik.Reporting.Drawing.Unit.Inch(0.50031673908233643R))
        Me.TextBox34.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox34.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox34.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox34.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox34.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox34.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox34.Value = "AWB NO. :"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = False
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.91029864549636841R), Telerik.Reporting.Drawing.Unit.Inch(0.6093064546585083R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6895439624786377R), Telerik.Reporting.Drawing.Unit.Inch(0.19069433212280273R))
        Me.TextBox5.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox5.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox5.Value = "= Fields.ClientName"
        '
        'TextBox22
        '
        Me.TextBox22.CanGrow = False
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.6093064546585083R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.91021984815597534R), Telerik.Reporting.Drawing.Unit.Inch(0.20023682713508606R))
        Me.TextBox22.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox22.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox22.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox22.Value = "Consignor :"
        '
        'TextBox30
        '
        Me.TextBox30.CanGrow = False
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(1.6998425722122192R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89996069669723511R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox30.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox30.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox30.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox30.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox30.Value = "Ref. No. :"
        '
        'TextBox31
        '
        Me.TextBox31.CanGrow = False
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.91029882431030273R), Telerik.Reporting.Drawing.Unit.Inch(1.6998425722122192R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.099881649017334R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox31.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox31.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox31.Value = "= Fields.RefNO"
        '
        'TextBox32
        '
        Me.TextBox32.CanGrow = False
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.0102593898773193R), Telerik.Reporting.Drawing.Unit.Inch(1.6998425722122192R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49811381101608276R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox32.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox32.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox32.Value = "Date :"
        '
        'TextBox33
        '
        Me.TextBox33.CanGrow = False
        Me.TextBox33.Format = "{0:dd/MM/yyyy}"
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.5084517002105713R), Telerik.Reporting.Drawing.Unit.Inch(1.6998425722122192R))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.091547966003418R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox33.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox33.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox33.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox33.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox33.Value = "= Fields.DATE"
        '
        'TextBox45
        '
        Me.TextBox45.CanGrow = False
        Me.TextBox45.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.91029864549636841R), Telerik.Reporting.Drawing.Unit.Inch(3.0005123615264893R))
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6895439624786377R), Telerik.Reporting.Drawing.Unit.Inch(0.19932988286018372R))
        Me.TextBox45.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox45.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox45.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox45.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox45.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox45.Value = ""
        '
        'SqlDataSource2
        '
        Me.SqlDataSource2.ConnectionString = "CustomSKMailing"
        Me.SqlDataSource2.Name = "SqlDataSource2"
        Me.SqlDataSource2.SelectCommand = resources.GetString("SqlDataSource2.SelectCommand")
        '
        'List2
        '
        Me.List2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(3.5999999046325684R)))
        Me.List2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(3.5996842384338379R)))
        Me.List2.Body.SetCellContent(0, 0, Me.Panel1)
        TableGroup3.Name = "ColumnGroup"
        Me.List2.ColumnGroups.Add(TableGroup3)
        Me.List2.DataSource = Me.SqlDataSource1
        Me.List2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel1})
        Me.List2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0677170753479R), Telerik.Reporting.Drawing.Unit.Inch(0.00023714701819699258R))
        Me.List2.Name = "List2"
        TableGroup4.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup4.Name = "DetailGroup"
        Me.List2.RowGroups.Add(TableGroup4)
        Me.List2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.5999999046325684R), Telerik.Reporting.Drawing.Unit.Inch(3.5996842384338379R))
        '
        'Panel1
        '
        Me.Panel1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox14, Me.TextBox16, Me.TextBox17, Me.TextBox18, Barcode1, Me.TextBox19, Me.TextBox20, Me.TextBox21, Me.TextBox36, Me.TextBox40, Me.TextBox42, Me.TextBox3, Me.TextBox4, Me.TextBox50})
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.5999999046325684R), Telerik.Reporting.Drawing.Unit.Inch(3.5996842384338379R))
        Me.Panel1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = False
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.5999999046325684R), Telerik.Reporting.Drawing.Unit.Inch(0.3999999463558197R))
        Me.TextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox1.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox1.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox1.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox1.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "= Fields.Comapny_Name"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = False
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.60914802551269531R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89996069669723511R), Telerik.Reporting.Drawing.Unit.Inch(0.20031645894050598R))
        Me.TextBox6.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox6.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox6.Value = "Consignor :"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = False
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.90891009569168091R), Telerik.Reporting.Drawing.Unit.Inch(0.60914802551269531R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.69374942779541R), Telerik.Reporting.Drawing.Unit.Inch(0.20031675696372986R))
        Me.TextBox7.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox7.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.Value = "= Fields.ClientName"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = False
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.81884926557540894R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.90000009536743164R), Telerik.Reporting.Drawing.Unit.Inch(0.19069421291351318R))
        Me.TextBox8.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox8.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "Consignee :"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = False
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.900079071521759R), Telerik.Reporting.Drawing.Unit.Inch(0.8095434308052063R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6999204158782959R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox9.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox9.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox9.Value = "= Fields.NAME"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = False
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0096222162246704R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.899881899356842R), Telerik.Reporting.Drawing.Unit.Inch(0.68998301029205322R))
        Me.TextBox10.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox10.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox10.Value = "Address : "
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = False
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.90628939867019653R), Telerik.Reporting.Drawing.Unit.Inch(1.0096222162246704R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6937103271484375R), Telerik.Reporting.Drawing.Unit.Inch(0.68978583812713623R))
        Me.TextBox11.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox11.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox11.Value = "= Fields.ADD_1 + "","" + Fields.ADD_2 + "","" + Fields.ADD_3 + "","" + Fields.STATE + """ & _
    ","" + Fields.PIN"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = False
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(1.6996841430664062R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89964532852172852R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox12.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox12.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox12.Value = "Ref. No. :"
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = False
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.90891009569168091R), Telerik.Reporting.Drawing.Unit.Inch(1.6996841430664062R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1233499050140381R), Telerik.Reporting.Drawing.Unit.Inch(0.19089138507843018R))
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox14.Value = "= Fields.RefNO"
        '
        'TextBox16
        '
        Me.TextBox16.CanGrow = False
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.0323390960693359R), Telerik.Reporting.Drawing.Unit.Inch(1.6996841430664062R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49992117285728455R), Telerik.Reporting.Drawing.Unit.Inch(0.19069412350654602R))
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox16.Value = "Date :"
        '
        'TextBox17
        '
        Me.TextBox17.CanGrow = False
        Me.TextBox17.Format = "{0:dd/MM/yyyy}"
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.5323390960693359R), Telerik.Reporting.Drawing.Unit.Inch(1.6994868516921997R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0676608085632324R), Telerik.Reporting.Drawing.Unit.Inch(0.19089138507843018R))
        Me.TextBox17.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox17.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox17.Value = "= Fields.DATE"
        '
        'TextBox18
        '
        Me.TextBox18.CanGrow = False
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(1.8997629880905151R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89964574575424194R), Telerik.Reporting.Drawing.Unit.Inch(0.500316858291626R))
        Me.TextBox18.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox18.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox18.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox18.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox18.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox18.Value = "AWB NO. :"
        '
        'TextBox19
        '
        Me.TextBox19.CanGrow = False
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.00000000015522043372850902R), Telerik.Reporting.Drawing.Unit.Inch(2.4001586437225342R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.90621060132980347R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox19.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox19.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox19.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox19.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox19.Value = "Reciever Name :"
        '
        'TextBox20
        '
        Me.TextBox20.CanGrow = False
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.00000000015522043372850902R), Telerik.Reporting.Drawing.Unit.Inch(2.6002376079559326R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.90621054172515869R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox20.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox20.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox20.Value = "Signature :"
        '
        'TextBox21
        '
        Me.TextBox21.CanGrow = False
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(2.8003165721893311R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89996081590652466R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox21.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox21.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox21.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox21.Value = "Dely. Date :"
        '
        'TextBox36
        '
        Me.TextBox36.CanGrow = False
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(3.0003936290740967R))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.900000274181366R), Telerik.Reporting.Drawing.Unit.Inch(0.19932988286018372R))
        Me.TextBox36.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox36.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox36.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox36.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox36.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox36.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox36.Value = "Tel No. :"
        '
        'TextBox40
        '
        Me.TextBox40.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(3.1997630596160889R))
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.5999996662139893R), Telerik.Reporting.Drawing.Unit.Inch(0.3998819887638092R))
        Me.TextBox40.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox40.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox40.Value = ""
        '
        'TextBox42
        '
        Me.TextBox42.CanGrow = False
        Me.TextBox42.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.90628939867019653R), Telerik.Reporting.Drawing.Unit.Inch(2.4001586437225342R))
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6859538555145264R), Telerik.Reporting.Drawing.Unit.Inch(0.60015791654586792R))
        Me.TextBox42.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox42.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox42.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox42.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox42.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox42.Value = ""
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3124213218688965R), Telerik.Reporting.Drawing.Unit.Inch(0.19956628978252411R))
        Me.TextBox3.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox3.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox3.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox3.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "Mob. : 8080770754"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.3125R), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2874996662139893R), Telerik.Reporting.Drawing.Unit.Inch(0.19956628978252411R))
        Me.TextBox4.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox4.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox4.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox4.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.Value = "Website:-www.skmailing.com"
        '
        'TextBox50
        '
        Me.TextBox50.CanGrow = False
        Me.TextBox50.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.90628939867019653R), Telerik.Reporting.Drawing.Unit.Inch(3.0003955364227295R))
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6859536170959473R), Telerik.Reporting.Drawing.Unit.Inch(0.19932988286018372R))
        Me.TextBox50.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox50.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox50.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox50.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox50.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox50.Value = ""
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "CustomSKMailing"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'POD
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail})
        Me.Name = "POD"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(7.6599998474121094R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents List1 As Telerik.Reporting.List
    Friend WithEvents Panel3 As Telerik.Reporting.Panel
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents List2 As Telerik.Reporting.List
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox36 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource2 As Telerik.Reporting.SqlDataSource
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox40 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox41 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox42 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox34 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox33 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox45 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox50 As Telerik.Reporting.TextBox
End Class