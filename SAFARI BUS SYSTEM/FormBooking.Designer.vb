<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBooking
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
        ComBoxFrom = New ComboBox()
        ComBoxTo = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        ComBoxStation = New ComboBox()
        BtnBook = New Button()
        NmrcSeatNo = New NumericUpDown()
        LblSeatNo = New Label()
        BtnLayout = New Button()
        LblHomeTitle = New Label()
        NmrcPrice = New NumericUpDown()
        LblPrice = New Label()
        BtnPrices = New Button()
        CType(NmrcSeatNo, ComponentModel.ISupportInitialize).BeginInit()
        CType(NmrcPrice, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComBoxFrom
        ' 
        ComBoxFrom.FormattingEnabled = True
        ComBoxFrom.Items.AddRange(New Object() {"MOMBASA", "NAIROBI", "NAKURU", "ELDORET", "KITALE", "MALABA"})
        ComBoxFrom.Location = New Point(59, 79)
        ComBoxFrom.Margin = New Padding(3, 4, 3, 4)
        ComBoxFrom.Name = "ComBoxFrom"
        ComBoxFrom.Size = New Size(279, 29)
        ComBoxFrom.TabIndex = 0
        ComBoxFrom.Text = "From"
        ' 
        ' ComBoxTo
        ' 
        ComBoxTo.FormattingEnabled = True
        ComBoxTo.Items.AddRange(New Object() {"MOMBASA", "NAIROBI", "NAKURU", "ELDORET", "KITALE", "MALABA"})
        ComBoxTo.Location = New Point(59, 130)
        ComBoxTo.Margin = New Padding(3, 4, 3, 4)
        ComBoxTo.Name = "ComBoxTo"
        ComBoxTo.Size = New Size(279, 29)
        ComBoxTo.TabIndex = 2
        ComBoxTo.Text = "To"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(59, 179)
        DateTimePicker1.Margin = New Padding(3, 4, 3, 4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(279, 29)
        DateTimePicker1.TabIndex = 3
        ' 
        ' ComBoxStation
        ' 
        ComBoxStation.FormattingEnabled = True
        ComBoxStation.Location = New Point(59, 232)
        ComBoxStation.Name = "ComBoxStation"
        ComBoxStation.Size = New Size(279, 29)
        ComBoxStation.TabIndex = 4
        ComBoxStation.Text = "Station name"
        ' 
        ' BtnBook
        ' 
        BtnBook.Location = New Point(138, 371)
        BtnBook.Name = "BtnBook"
        BtnBook.Size = New Size(93, 31)
        BtnBook.TabIndex = 5
        BtnBook.Text = "Book"
        BtnBook.UseVisualStyleBackColor = True
        ' 
        ' NmrcSeatNo
        ' 
        NmrcSeatNo.Location = New Point(127, 278)
        NmrcSeatNo.Name = "NmrcSeatNo"
        NmrcSeatNo.Size = New Size(120, 29)
        NmrcSeatNo.TabIndex = 7
        ' 
        ' LblSeatNo
        ' 
        LblSeatNo.AutoSize = True
        LblSeatNo.BorderStyle = BorderStyle.FixedSingle
        LblSeatNo.Location = New Point(59, 280)
        LblSeatNo.Name = "LblSeatNo"
        LblSeatNo.Size = New Size(64, 23)
        LblSeatNo.TabIndex = 8
        LblSeatNo.Text = "Seat No."
        ' 
        ' BtnLayout
        ' 
        BtnLayout.Location = New Point(253, 276)
        BtnLayout.Name = "BtnLayout"
        BtnLayout.Size = New Size(98, 29)
        BtnLayout.TabIndex = 9
        BtnLayout.Text = "View Layout"
        BtnLayout.UseVisualStyleBackColor = True
        ' 
        ' LblHomeTitle
        ' 
        LblHomeTitle.AutoSize = True
        LblHomeTitle.Font = New Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblHomeTitle.Location = New Point(222, 25)
        LblHomeTitle.Name = "LblHomeTitle"
        LblHomeTitle.Size = New Size(223, 28)
        LblHomeTitle.TabIndex = 10
        LblHomeTitle.Text = "Book Now, Book Cheaper!!"
        ' 
        ' NmrcPrice
        ' 
        NmrcPrice.Location = New Point(127, 321)
        NmrcPrice.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        NmrcPrice.Name = "NmrcPrice"
        NmrcPrice.Size = New Size(120, 29)
        NmrcPrice.TabIndex = 7
        ' 
        ' LblPrice
        ' 
        LblPrice.AutoSize = True
        LblPrice.BorderStyle = BorderStyle.FixedSingle
        LblPrice.Location = New Point(59, 321)
        LblPrice.Name = "LblPrice"
        LblPrice.Size = New Size(41, 23)
        LblPrice.TabIndex = 8
        LblPrice.Text = "Price"
        ' 
        ' BtnPrices
        ' 
        BtnPrices.Location = New Point(253, 321)
        BtnPrices.Name = "BtnPrices"
        BtnPrices.Size = New Size(98, 30)
        BtnPrices.TabIndex = 11
        BtnPrices.Text = "View Prices"
        BtnPrices.UseVisualStyleBackColor = True
        ' 
        ' FormBooking
        ' 
        AutoScaleDimensions = New SizeF(8F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(539, 459)
        Controls.Add(BtnPrices)
        Controls.Add(LblHomeTitle)
        Controls.Add(BtnLayout)
        Controls.Add(LblPrice)
        Controls.Add(LblSeatNo)
        Controls.Add(NmrcPrice)
        Controls.Add(NmrcSeatNo)
        Controls.Add(BtnBook)
        Controls.Add(ComBoxStation)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComBoxTo)
        Controls.Add(ComBoxFrom)
        Font = New Font("Segoe Print", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormBooking"
        Text = "SAFARI BUS"
        CType(NmrcSeatNo, ComponentModel.ISupportInitialize).EndInit()
        CType(NmrcPrice, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComBoxFrom As ComboBox
    Friend WithEvents ComBoxTo As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComBoxStation As ComboBox
    Friend WithEvents BtnBook As Button
    Friend WithEvents NmrcSeatNo As NumericUpDown
    Friend WithEvents LblSeatNo As Label
    Friend WithEvents BtnLayout As Button
    Friend WithEvents LblHomeTitle As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents BtnPrices As Button
    Friend WithEvents NmrcPrice As NumericUpDown
    Friend WithEvents LblPrice As Label

End Class
