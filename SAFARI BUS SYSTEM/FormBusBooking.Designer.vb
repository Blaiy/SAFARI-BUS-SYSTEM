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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBooking))
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        btnSearch = New Button()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        HomeToolStripMenuItem = New ToolStripMenuItem()
        ContactsToolStripMenuItem = New ToolStripMenuItem()
        AboutUsToolStripMenuItem = New ToolStripMenuItem()
        SignInRegisterToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"LAMU", "MPEKETONI", "MALINDI", "KILIFI", "MOMBASA", "VOI", "KWALE", "NAIROBI", "NAIVASHA", "NAKURU", "KITALE", "BUNGOMA", "KIAMBU", "BONDO", "KISUMU", "KIRINYAGA", "MERU", "EMBU", "MALABA", "ELDORET", "KAKAMEGA", "NYERI", "TURKANA", "KERICHO", "BOMET", "BUSIA", "KISII", "MACHAKOS", "KITUI", "VIHIGA", "DAR-ES-SALAAM", "ARUSHA", "KAMPALA", "KIGALI"})
        ComboBox1.Location = New Point(47, 37)
        ComboBox1.Margin = New Padding(3, 4, 3, 4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(279, 29)
        ComboBox1.TabIndex = 0
        ComboBox1.Text = "From"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"LAMU", "MPEKETONI", "MALINDI", "KILIFI", "MOMBASA", "VOI", "KWALE", "NAIROBI", "NAIVASHA", "NAKURU", "KITALE", "BUNGOMA", "KIAMBU", "BONDO", "KISUMU", "KIRINYAGA", "MERU", "EMBU", "MALABA", "ELDORET", "KAKAMEGA", "NYERI", "TURKANA", "KERICHO", "BOMET", "BUSIA", "KISII", "MACHAKOS", "KITUI", "VIHIGA", "DAR-ES-SALAAM", "ARUSHA", "KAMPALA", "KIGALI"})
        ComboBox2.Location = New Point(47, 77)
        ComboBox2.Margin = New Padding(3, 4, 3, 4)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(279, 29)
        ComboBox2.TabIndex = 2
        ComboBox2.Text = "To"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(47, 118)
        DateTimePicker1.Margin = New Padding(3, 4, 3, 4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(279, 29)
        DateTimePicker1.TabIndex = 3
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(47, 158)
        DateTimePicker2.Margin = New Padding(3, 4, 3, 4)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(279, 29)
        DateTimePicker2.TabIndex = 4
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(44, 207)
        btnSearch.Margin = New Padding(3, 4, 3, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(282, 32)
        btnSearch.TabIndex = 5
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ActiveCaption
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(420, 24)
        MenuStrip1.TabIndex = 6
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {HomeToolStripMenuItem, ContactsToolStripMenuItem, AboutUsToolStripMenuItem, SignInRegisterToolStripMenuItem})
        ToolStripMenuItem1.ForeColor = Color.Snow
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(53, 20)
        ToolStripMenuItem1.Text = "MENU"
        ' 
        ' HomeToolStripMenuItem
        ' 
        HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        HomeToolStripMenuItem.Size = New Size(160, 22)
        HomeToolStripMenuItem.Text = "Home"
        ' 
        ' ContactsToolStripMenuItem
        ' 
        ContactsToolStripMenuItem.Name = "ContactsToolStripMenuItem"
        ContactsToolStripMenuItem.Size = New Size(160, 22)
        ContactsToolStripMenuItem.Text = "Contact Us"
        ' 
        ' AboutUsToolStripMenuItem
        ' 
        AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        AboutUsToolStripMenuItem.Size = New Size(160, 22)
        AboutUsToolStripMenuItem.Text = "About Us"
        ' 
        ' SignInRegisterToolStripMenuItem
        ' 
        SignInRegisterToolStripMenuItem.Name = "SignInRegisterToolStripMenuItem"
        SignInRegisterToolStripMenuItem.Size = New Size(160, 22)
        SignInRegisterToolStripMenuItem.Text = "Sign In/ Register"
        ' 
        ' FormBooking
        ' 
        AutoScaleDimensions = New SizeF(8F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(420, 376)
        Controls.Add(btnSearch)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe Print", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormBooking"
        Text = "SAFARI BUS"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents btnSearch As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SignInRegisterToolStripMenuItem As ToolStripMenuItem

End Class
