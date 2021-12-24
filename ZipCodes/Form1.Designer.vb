<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmZIPGITTER
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
        Me.btnHarrison = New System.Windows.Forms.Button()
        Me.btnNorwood = New System.Windows.Forms.Button()
        Me.btnErlanger = New System.Windows.Forms.Button()
        Me.btnFlorence = New System.Windows.Forms.Button()
        Me.btnLawrenceburg = New System.Windows.Forms.Button()
        Me.btnRisingSun = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtZipcode = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnHarrison
        '
        Me.btnHarrison.AutoSize = True
        Me.btnHarrison.Location = New System.Drawing.Point(101, 36)
        Me.btnHarrison.Name = "btnHarrison"
        Me.btnHarrison.Size = New System.Drawing.Size(84, 23)
        Me.btnHarrison.TabIndex = 0
        Me.btnHarrison.Text = "Harrison, OH"
        Me.btnHarrison.UseVisualStyleBackColor = True
        '
        'btnNorwood
        '
        Me.btnNorwood.AutoSize = True
        Me.btnNorwood.Location = New System.Drawing.Point(101, 88)
        Me.btnNorwood.Name = "btnNorwood"
        Me.btnNorwood.Size = New System.Drawing.Size(88, 23)
        Me.btnNorwood.TabIndex = 1
        Me.btnNorwood.Text = "Norwood, OH"
        Me.btnNorwood.UseVisualStyleBackColor = True
        '
        'btnErlanger
        '
        Me.btnErlanger.AutoSize = True
        Me.btnErlanger.Location = New System.Drawing.Point(101, 142)
        Me.btnErlanger.Name = "btnErlanger"
        Me.btnErlanger.Size = New System.Drawing.Size(79, 23)
        Me.btnErlanger.TabIndex = 2
        Me.btnErlanger.Text = "Erlanger, KY"
        Me.btnErlanger.UseVisualStyleBackColor = True
        '
        'btnFlorence
        '
        Me.btnFlorence.AutoSize = True
        Me.btnFlorence.Location = New System.Drawing.Point(101, 200)
        Me.btnFlorence.Name = "btnFlorence"
        Me.btnFlorence.Size = New System.Drawing.Size(78, 23)
        Me.btnFlorence.TabIndex = 3
        Me.btnFlorence.Text = "Florence, KY"
        Me.btnFlorence.UseVisualStyleBackColor = True
        '
        'btnLawrenceburg
        '
        Me.btnLawrenceburg.AutoSize = True
        Me.btnLawrenceburg.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnLawrenceburg.Location = New System.Drawing.Point(101, 258)
        Me.btnLawrenceburg.Name = "btnLawrenceburg"
        Me.btnLawrenceburg.Size = New System.Drawing.Size(102, 23)
        Me.btnLawrenceburg.TabIndex = 4
        Me.btnLawrenceburg.Text = "Lawrenceburg, IN"
        Me.btnLawrenceburg.UseVisualStyleBackColor = True
        '
        'btnRisingSun
        '
        Me.btnRisingSun.AutoSize = True
        Me.btnRisingSun.Location = New System.Drawing.Point(101, 317)
        Me.btnRisingSun.Name = "btnRisingSun"
        Me.btnRisingSun.Size = New System.Drawing.Size(85, 23)
        Me.btnRisingSun.TabIndex = 5
        Me.btnRisingSun.Text = "Rising Sun, IN"
        Me.btnRisingSun.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(351, 317)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtZipcode
        '
        Me.txtZipcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtZipcode.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtZipcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipcode.Location = New System.Drawing.Point(317, 173)
        Me.txtZipcode.Name = "txtZipcode"
        Me.txtZipcode.Size = New System.Drawing.Size(154, 29)
        Me.txtZipcode.TabIndex = 7
        Me.txtZipcode.Text = "GET ZIP HERE!"
        '
        'frmZIPGITTER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtZipcode)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRisingSun)
        Me.Controls.Add(Me.btnLawrenceburg)
        Me.Controls.Add(Me.btnFlorence)
        Me.Controls.Add(Me.btnErlanger)
        Me.Controls.Add(Me.btnNorwood)
        Me.Controls.Add(Me.btnHarrison)
        Me.Name = "frmZIPGITTER"
        Me.Text = "ZipGitter!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHarrison As Button
    Friend WithEvents btnNorwood As Button
    Friend WithEvents btnErlanger As Button
    Friend WithEvents btnFlorence As Button
    Friend WithEvents btnLawrenceburg As Button
    Friend WithEvents btnRisingSun As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtZipcode As TextBox
End Class
