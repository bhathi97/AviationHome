<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.cbShiftTime = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnAddPlanesToTable = New FontAwesome.Sharp.IconButton()
        Me.lblShiftShowing = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblForShowingDay = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnXML = New FontAwesome.Sharp.IconButton()
        Me.btnPrint = New FontAwesome.Sharp.IconButton()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnRICAddToTable = New FontAwesome.Sharp.IconButton()
        Me.btnAddRICBack = New FontAwesome.Sharp.IconButton()
        Me.cbRemovedRIC = New System.Windows.Forms.ComboBox()
        Me.RemoveRIC = New FontAwesome.Sharp.IconButton()
        Me.lvRic = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnCMAddToTable = New FontAwesome.Sharp.IconButton()
        Me.btnAddCMBack = New FontAwesome.Sharp.IconButton()
        Me.cbRemovedCM = New System.Windows.Forms.ComboBox()
        Me.RemoveCM = New FontAwesome.Sharp.IconButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lvCrewman = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbGroupPicker = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLIGHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lines = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMain
        '
        Me.dgvMain.AllowDrop = True
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToResizeColumns = False
        Me.dgvMain.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.noo, Me.fli, Me.Column10, Me.Column4, Me.lines, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMain.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgvMain.Location = New System.Drawing.Point(5, 5)
        Me.dgvMain.Name = "dgvMain"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMain.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMain.RowHeadersWidth = 20
        Me.dgvMain.RowTemplate.Height = 20
        Me.dgvMain.Size = New System.Drawing.Size(905, 552)
        Me.dgvMain.TabIndex = 0
        '
        'cbShiftTime
        '
        Me.cbShiftTime.FormattingEnabled = True
        Me.cbShiftTime.Location = New System.Drawing.Point(105, 37)
        Me.cbShiftTime.Name = "cbShiftTime"
        Me.cbShiftTime.Size = New System.Drawing.Size(174, 23)
        Me.cbShiftTime.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1165, 697)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 61)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1165, 636)
        Me.Panel4.TabIndex = 25
        '
        'Panel6
        '
        Me.Panel6.AutoSize = True
        Me.Panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.dgvMain)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 70)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel6.Size = New System.Drawing.Size(919, 566)
        Me.Panel6.TabIndex = 34
        '
        'Panel5
        '
        Me.Panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.btnAddPlanesToTable)
        Me.Panel5.Controls.Add(Me.lblShiftShowing)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.lblForShowingDay)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.tpDate)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.cbShiftTime)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel5.Size = New System.Drawing.Size(919, 70)
        Me.Panel5.TabIndex = 33
        '
        'btnAddPlanesToTable
        '
        Me.btnAddPlanesToTable.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAddPlanesToTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddPlanesToTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddPlanesToTable.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddPlanesToTable.IconChar = FontAwesome.Sharp.IconChar.PlaneCircleCheck
        Me.btnAddPlanesToTable.IconColor = System.Drawing.Color.Crimson
        Me.btnAddPlanesToTable.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnAddPlanesToTable.IconSize = 30
        Me.btnAddPlanesToTable.Location = New System.Drawing.Point(807, 5)
        Me.btnAddPlanesToTable.Margin = New System.Windows.Forms.Padding(10)
        Me.btnAddPlanesToTable.Name = "btnAddPlanesToTable"
        Me.btnAddPlanesToTable.Padding = New System.Windows.Forms.Padding(5)
        Me.btnAddPlanesToTable.Size = New System.Drawing.Size(103, 56)
        Me.btnAddPlanesToTable.TabIndex = 31
        Me.btnAddPlanesToTable.UseVisualStyleBackColor = False
        '
        'lblShiftShowing
        '
        Me.lblShiftShowing.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblShiftShowing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShiftShowing.Location = New System.Drawing.Point(466, 37)
        Me.lblShiftShowing.Name = "lblShiftShowing"
        Me.lblShiftShowing.Size = New System.Drawing.Size(129, 22)
        Me.lblShiftShowing.TabIndex = 30
        Me.lblShiftShowing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(466, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Shift"
        '
        'lblForShowingDay
        '
        Me.lblForShowingDay.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblForShowingDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblForShowingDay.Location = New System.Drawing.Point(321, 37)
        Me.lblForShowingDay.Name = "lblForShowingDay"
        Me.lblForShowingDay.Size = New System.Drawing.Size(129, 22)
        Me.lblForShowingDay.TabIndex = 28
        Me.lblForShowingDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(321, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Day"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Date"
        '
        'tpDate
        '
        Me.tpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tpDate.Location = New System.Drawing.Point(105, 9)
        Me.tpDate.Name = "tpDate"
        Me.tpDate.Size = New System.Drawing.Size(174, 23)
        Me.tpDate.TabIndex = 24
        Me.tpDate.Value = New Date(2023, 2, 25, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Shift Time"
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnXML)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.IconPictureBox1)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.cbGroupPicker)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(919, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(246, 636)
        Me.Panel2.TabIndex = 32
        '
        'btnXML
        '
        Me.btnXML.BackColor = System.Drawing.Color.Gainsboro
        Me.btnXML.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnXML.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnXML.IconChar = FontAwesome.Sharp.IconChar.FileExcel
        Me.btnXML.IconColor = System.Drawing.Color.DarkBlue
        Me.btnXML.IconFont = FontAwesome.Sharp.IconFont.Regular
        Me.btnXML.IconSize = 25
        Me.btnXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXML.Location = New System.Drawing.Point(27, 571)
        Me.btnXML.Name = "btnXML"
        Me.btnXML.Size = New System.Drawing.Size(190, 40)
        Me.btnXML.TabIndex = 21
        Me.btnXML.Text = "Export as Excel"
        Me.btnXML.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnXML.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPrint.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnPrint.IconChar = FontAwesome.Sharp.IconChar.FilePdf
        Me.btnPrint.IconColor = System.Drawing.Color.DarkGreen
        Me.btnPrint.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPrint.IconSize = 25
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(27, 525)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(190, 40)
        Me.btnPrint.TabIndex = 20
        Me.btnPrint.Text = "Save as PDF"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IconPictureBox1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Sliders
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.Desktop
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconPictureBox1.IconSize = 28
        Me.IconPictureBox1.Location = New System.Drawing.Point(204, 6)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(30, 28)
        Me.IconPictureBox1.TabIndex = 19
        Me.IconPictureBox1.TabStop = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.btnRICAddToTable)
        Me.Panel8.Controls.Add(Me.btnAddRICBack)
        Me.Panel8.Controls.Add(Me.cbRemovedRIC)
        Me.Panel8.Controls.Add(Me.RemoveRIC)
        Me.Panel8.Controls.Add(Me.lvRic)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Location = New System.Drawing.Point(4, 289)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(237, 205)
        Me.Panel8.TabIndex = 18
        '
        'btnRICAddToTable
        '
        Me.btnRICAddToTable.BackColor = System.Drawing.Color.Gainsboro
        Me.btnRICAddToTable.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRICAddToTable.ForeColor = System.Drawing.Color.Crimson
        Me.btnRICAddToTable.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.btnRICAddToTable.IconColor = System.Drawing.Color.Crimson
        Me.btnRICAddToTable.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnRICAddToTable.IconSize = 25
        Me.btnRICAddToTable.Location = New System.Drawing.Point(10, 158)
        Me.btnRICAddToTable.Name = "btnRICAddToTable"
        Me.btnRICAddToTable.Size = New System.Drawing.Size(215, 35)
        Me.btnRICAddToTable.TabIndex = 20
        Me.btnRICAddToTable.Text = "Duty Assign"
        Me.btnRICAddToTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRICAddToTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRICAddToTable.UseVisualStyleBackColor = False
        '
        'btnAddRICBack
        '
        Me.btnAddRICBack.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
        Me.btnAddRICBack.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.btnAddRICBack.IconColor = System.Drawing.Color.Black
        Me.btnAddRICBack.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnAddRICBack.IconSize = 20
        Me.btnAddRICBack.Location = New System.Drawing.Point(127, 91)
        Me.btnAddRICBack.Name = "btnAddRICBack"
        Me.btnAddRICBack.Size = New System.Drawing.Size(100, 30)
        Me.btnAddRICBack.TabIndex = 19
        Me.btnAddRICBack.Text = "Add"
        Me.btnAddRICBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddRICBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddRICBack.UseVisualStyleBackColor = True
        '
        'cbRemovedRIC
        '
        Me.cbRemovedRIC.FormattingEnabled = True
        Me.cbRemovedRIC.Location = New System.Drawing.Point(128, 63)
        Me.cbRemovedRIC.Name = "cbRemovedRIC"
        Me.cbRemovedRIC.Size = New System.Drawing.Size(98, 23)
        Me.cbRemovedRIC.TabIndex = 18
        '
        'RemoveRIC
        '
        Me.RemoveRIC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RemoveRIC.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
        Me.RemoveRIC.IconChar = FontAwesome.Sharp.IconChar.UserSlash
        Me.RemoveRIC.IconColor = System.Drawing.Color.Black
        Me.RemoveRIC.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.RemoveRIC.IconSize = 20
        Me.RemoveRIC.Location = New System.Drawing.Point(127, 28)
        Me.RemoveRIC.Name = "RemoveRIC"
        Me.RemoveRIC.Size = New System.Drawing.Size(100, 30)
        Me.RemoveRIC.TabIndex = 16
        Me.RemoveRIC.Text = "Remove"
        Me.RemoveRIC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RemoveRIC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RemoveRIC.UseVisualStyleBackColor = True
        '
        'lvRic
        '
        Me.lvRic.AllowDrop = True
        Me.lvRic.FormattingEnabled = True
        Me.lvRic.ItemHeight = 15
        Me.lvRic.Location = New System.Drawing.Point(10, 28)
        Me.lvRic.Name = "lvRic"
        Me.lvRic.Size = New System.Drawing.Size(112, 124)
        Me.lvRic.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(235, 24)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "RIC"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Control
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.btnCMAddToTable)
        Me.Panel7.Controls.Add(Me.btnAddCMBack)
        Me.Panel7.Controls.Add(Me.cbRemovedCM)
        Me.Panel7.Controls.Add(Me.RemoveCM)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.lvCrewman)
        Me.Panel7.Location = New System.Drawing.Point(4, 72)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(237, 205)
        Me.Panel7.TabIndex = 17
        '
        'btnCMAddToTable
        '
        Me.btnCMAddToTable.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCMAddToTable.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCMAddToTable.ForeColor = System.Drawing.Color.Crimson
        Me.btnCMAddToTable.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.btnCMAddToTable.IconColor = System.Drawing.Color.Crimson
        Me.btnCMAddToTable.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnCMAddToTable.IconSize = 25
        Me.btnCMAddToTable.Location = New System.Drawing.Point(10, 158)
        Me.btnCMAddToTable.Name = "btnCMAddToTable"
        Me.btnCMAddToTable.Size = New System.Drawing.Size(215, 35)
        Me.btnCMAddToTable.TabIndex = 19
        Me.btnCMAddToTable.Text = "Duty Assign"
        Me.btnCMAddToTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCMAddToTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCMAddToTable.UseVisualStyleBackColor = False
        '
        'btnAddCMBack
        '
        Me.btnAddCMBack.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
        Me.btnAddCMBack.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.btnAddCMBack.IconColor = System.Drawing.Color.Black
        Me.btnAddCMBack.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnAddCMBack.IconSize = 20
        Me.btnAddCMBack.Location = New System.Drawing.Point(127, 91)
        Me.btnAddCMBack.Name = "btnAddCMBack"
        Me.btnAddCMBack.Size = New System.Drawing.Size(100, 30)
        Me.btnAddCMBack.TabIndex = 18
        Me.btnAddCMBack.Text = "Add"
        Me.btnAddCMBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddCMBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddCMBack.UseVisualStyleBackColor = True
        '
        'cbRemovedCM
        '
        Me.cbRemovedCM.FormattingEnabled = True
        Me.cbRemovedCM.Location = New System.Drawing.Point(128, 63)
        Me.cbRemovedCM.Name = "cbRemovedCM"
        Me.cbRemovedCM.Size = New System.Drawing.Size(98, 23)
        Me.cbRemovedCM.TabIndex = 17
        '
        'RemoveCM
        '
        Me.RemoveCM.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
        Me.RemoveCM.IconChar = FontAwesome.Sharp.IconChar.UserSlash
        Me.RemoveCM.IconColor = System.Drawing.Color.Black
        Me.RemoveCM.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.RemoveCM.IconSize = 20
        Me.RemoveCM.Location = New System.Drawing.Point(127, 28)
        Me.RemoveCM.Name = "RemoveCM"
        Me.RemoveCM.Size = New System.Drawing.Size(100, 30)
        Me.RemoveCM.TabIndex = 18
        Me.RemoveCM.Text = "Remove"
        Me.RemoveCM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RemoveCM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RemoveCM.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(235, 21)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "CREWMAN"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvCrewman
        '
        Me.lvCrewman.AllowDrop = True
        Me.lvCrewman.FormattingEnabled = True
        Me.lvCrewman.IntegralHeight = False
        Me.lvCrewman.ItemHeight = 15
        Me.lvCrewman.Location = New System.Drawing.Point(10, 28)
        Me.lvCrewman.Name = "lvCrewman"
        Me.lvCrewman.Size = New System.Drawing.Size(112, 124)
        Me.lvCrewman.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Location = New System.Drawing.Point(5, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(232, 29)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Selection Panal"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 15)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Group"
        '
        'cbGroupPicker
        '
        Me.cbGroupPicker.FormattingEnabled = True
        Me.cbGroupPicker.Location = New System.Drawing.Point(45, 42)
        Me.cbGroupPicker.Name = "cbGroupPicker"
        Me.cbGroupPicker.Size = New System.Drawing.Size(44, 23)
        Me.cbGroupPicker.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1165, 61)
        Me.Panel3.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(329, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(589, 23)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "CEYLON PETROLEUM CORPORATION - AVIATION FUNCTION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(499, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 19)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "DAILY WORK SCHEDULE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-320, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(200, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(121, 57)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 26
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(924, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(121, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "BAY NO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'NO
        '
        Me.NO.HeaderText = "NO"
        Me.NO.Name = "NO"
        '
        'FLIGHT
        '
        Me.FLIGHT.HeaderText = "FLIGHT"
        Me.FLIGHT.Name = "FLIGHT"
        '
        'Column1
        '
        Me.Column1.HeaderText = "BAY NO"
        Me.Column1.Name = "Column1"
        '
        'noo
        '
        Me.noo.HeaderText = "NO"
        Me.noo.Name = "noo"
        Me.noo.Width = 50
        '
        'fli
        '
        Me.fli.HeaderText = "FLIGHT"
        Me.fli.Name = "fli"
        Me.fli.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column10
        '
        Me.Column10.HeaderText = "ROUTE"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 70
        '
        'Column4
        '
        Me.Column4.HeaderText = "ETA"
        Me.Column4.Name = "Column4"
        '
        'lines
        '
        Me.lines.HeaderText = "AIRLINES"
        Me.lines.Name = "lines"
        Me.lines.Width = 120
        '
        'Column6
        '
        Me.Column6.HeaderText = "RIC"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "OPERATOR"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "CREWMAN"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "REMARKS"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 155
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 697)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "HomeForm"
        Me.Text = "HomeForm"
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lvRic As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lvCrewman As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbGroupPicker As ComboBox
    Friend WithEvents cbShiftTime As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tpDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblForShowingDay As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblShiftShowing As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RemoveCM As FontAwesome.Sharp.IconButton
    Friend WithEvents RemoveRIC As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents cbRemovedCM As ComboBox
    Friend WithEvents btnAddCMBack As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCMAddToTable As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddRICBack As FontAwesome.Sharp.IconButton
    Friend WithEvents cbRemovedRIC As ComboBox
    Friend WithEvents btnRICAddToTable As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddPlanesToTable As FontAwesome.Sharp.IconButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NO As DataGridViewTextBoxColumn
    Friend WithEvents FLIGHT As DataGridViewTextBoxColumn
    Friend WithEvents dgvMain As DataGridView
    Friend WithEvents btnPrint As FontAwesome.Sharp.IconButton
    Friend WithEvents btnXML As FontAwesome.Sharp.IconButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents noo As DataGridViewTextBoxColumn
    Friend WithEvents fli As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents lines As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
