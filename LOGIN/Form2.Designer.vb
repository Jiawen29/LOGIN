<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnContact = New System.Windows.Forms.Button()
        Me.btnCompost = New System.Windows.Forms.Button()
        Me.btnDonate = New System.Windows.Forms.Button()
        Me.btnRecycle = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.btn1)
        Me.Panel3.Location = New System.Drawing.Point(12, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1443, 105)
        Me.Panel3.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LOGIN.My.Resources.Resources.WhatsApp_Image_2023_05_25_at_11_01_18_PM
        Me.PictureBox1.Location = New System.Drawing.Point(142, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn1
        '
        Me.btn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn1.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn1.FlatAppearance.BorderSize = 0
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.ForeColor = System.Drawing.Color.Transparent
        Me.btn1.Image = Global.LOGIN.My.Resources.Resources.menu_4_48
        Me.btn1.Location = New System.Drawing.Point(49, 13)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(87, 72)
        Me.btn1.TabIndex = 2
        Me.btn1.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(11, 101)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AccessibleDescription = "SC"
        Me.SplitContainer1.Panel1.AccessibleName = "SC_Panel1"
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSettings)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnContact)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnCompost)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDonate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRecycle)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnHome)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AccessibleName = "SC"
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Lavender
        Me.SplitContainer1.Panel2.Tag = "SC"
        Me.SplitContainer1.Size = New System.Drawing.Size(1441, 815)
        Me.SplitContainer1.SplitterDistance = 480
        Me.SplitContainer1.TabIndex = 2
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Castellar", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSettings.Image = Global.LOGIN.My.Resources.Resources.settings_9_48
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(50, 574)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(334, 102)
        Me.btnSettings.TabIndex = 12
        Me.btnSettings.Text = "SETTINGS"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnContact
        '
        Me.btnContact.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnContact.FlatAppearance.BorderSize = 0
        Me.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContact.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContact.ForeColor = System.Drawing.SystemColors.Control
        Me.btnContact.Image = Global.LOGIN.My.Resources.Resources.phone_48
        Me.btnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContact.Location = New System.Drawing.Point(50, 719)
        Me.btnContact.Name = "btnContact"
        Me.btnContact.Size = New System.Drawing.Size(353, 73)
        Me.btnContact.TabIndex = 11
        Me.btnContact.Text = "CONTACT US"
        Me.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnContact.UseVisualStyleBackColor = False
        '
        'btnCompost
        '
        Me.btnCompost.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCompost.FlatAppearance.BorderSize = 0
        Me.btnCompost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompost.Font = New System.Drawing.Font("Castellar", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompost.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCompost.Image = Global.LOGIN.My.Resources.Resources.Arkangl300_Trash_Trash_White_Empty_48
        Me.btnCompost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompost.Location = New System.Drawing.Point(50, 439)
        Me.btnCompost.Name = "btnCompost"
        Me.btnCompost.Size = New System.Drawing.Size(334, 102)
        Me.btnCompost.TabIndex = 10
        Me.btnCompost.Text = "COMPOST"
        Me.btnCompost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCompost.UseVisualStyleBackColor = False
        '
        'btnDonate
        '
        Me.btnDonate.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnDonate.FlatAppearance.BorderSize = 0
        Me.btnDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDonate.Font = New System.Drawing.Font("Castellar", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDonate.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDonate.Image = Global.LOGIN.My.Resources.Resources.pizza_2_48
        Me.btnDonate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDonate.Location = New System.Drawing.Point(63, 179)
        Me.btnDonate.Name = "btnDonate"
        Me.btnDonate.Size = New System.Drawing.Size(321, 102)
        Me.btnDonate.TabIndex = 9
        Me.btnDonate.Text = "DONATE"
        Me.btnDonate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDonate.UseVisualStyleBackColor = False
        '
        'btnRecycle
        '
        Me.btnRecycle.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnRecycle.FlatAppearance.BorderSize = 0
        Me.btnRecycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecycle.Font = New System.Drawing.Font("Castellar", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecycle.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRecycle.Image = Global.LOGIN.My.Resources.Resources.recycle_sign_48
        Me.btnRecycle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecycle.Location = New System.Drawing.Point(63, 312)
        Me.btnRecycle.Name = "btnRecycle"
        Me.btnRecycle.Size = New System.Drawing.Size(321, 102)
        Me.btnRecycle.TabIndex = 8
        Me.btnRecycle.Text = "RECYCLE"
        Me.btnRecycle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRecycle.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Castellar", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHome.Image = Global.LOGIN.My.Resources.Resources.house_48
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(63, 38)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(280, 102)
        Me.btnHome.TabIndex = 7
        Me.btnHome.Text = "HOME"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1453, 960)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private Sub btnContact_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If SplitContainer1.SplitterDistance > 80 Then
            Timer1.Enabled = True
        Else
            Timer2.Enabled = True
        End If
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If SplitContainer1.SplitterDistance > 80 Then
            SplitContainer1.SplitterDistance -= 10
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If SplitContainer1.SplitterDistance < 90 Then
            SplitContainer1.SplitterDistance += 120
        Else
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn1 As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnContact As Button
    Friend WithEvents btnCompost As Button
    Friend WithEvents btnDonate As Button
    Friend WithEvents btnRecycle As Button
    Friend WithEvents btnHome As Button

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

    End Sub

    Private Sub btnDonate_Click(sender As Object, e As EventArgs) Handles btnDonate.Click

    End Sub

    Private Sub btnRecycle_Click(sender As Object, e As EventArgs) Handles btnRecycle.Click

    End Sub

    Private Sub btnCompost_Click(sender As Object, e As EventArgs) Handles btnCompost.Click

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

    End Sub

    Private Sub btnContact_Click_1(sender As Object, e As EventArgs) Handles btnContact.Click

    End Sub
End Class
