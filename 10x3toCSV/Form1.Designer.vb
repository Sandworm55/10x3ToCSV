<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBrowseFrom = New System.Windows.Forms.Button()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.btnBrowseTo = New System.Windows.Forms.Button()
        Me.rdoCsv = New System.Windows.Forms.RadioButton()
        Me.rdoTxt = New System.Windows.Forms.RadioButton()
        Me.grpExportType = New System.Windows.Forms.GroupBox()
        Me.cbxRows = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkAltRowDelete = New System.Windows.Forms.CheckBox()
        Me.lblColomn = New System.Windows.Forms.Label()
        Me.txtColumn = New System.Windows.Forms.TextBox()
        Me.grpExportType.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(648, 17)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(79, 23)
        Me.btnConvert.TabIndex = 0
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(648, 42)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To"
        '
        'btnBrowseFrom
        '
        Me.btnBrowseFrom.Location = New System.Drawing.Point(523, 17)
        Me.btnBrowseFrom.Name = "btnBrowseFrom"
        Me.btnBrowseFrom.Size = New System.Drawing.Size(91, 24)
        Me.btnBrowseFrom.TabIndex = 4
        Me.btnBrowseFrom.Text = "Browse"
        Me.btnBrowseFrom.UseVisualStyleBackColor = True
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(67, 20)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(450, 20)
        Me.txtFrom.TabIndex = 5
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(67, 45)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(450, 20)
        Me.txtTo.TabIndex = 7
        '
        'btnBrowseTo
        '
        Me.btnBrowseTo.Location = New System.Drawing.Point(523, 42)
        Me.btnBrowseTo.Name = "btnBrowseTo"
        Me.btnBrowseTo.Size = New System.Drawing.Size(91, 24)
        Me.btnBrowseTo.TabIndex = 6
        Me.btnBrowseTo.Text = "Browse"
        Me.btnBrowseTo.UseVisualStyleBackColor = True
        '
        'rdoCsv
        '
        Me.rdoCsv.AutoSize = True
        Me.rdoCsv.Location = New System.Drawing.Point(6, 42)
        Me.rdoCsv.Name = "rdoCsv"
        Me.rdoCsv.Size = New System.Drawing.Size(45, 17)
        Me.rdoCsv.TabIndex = 8
        Me.rdoCsv.Text = ".csv"
        Me.rdoCsv.UseVisualStyleBackColor = True
        '
        'rdoTxt
        '
        Me.rdoTxt.AutoSize = True
        Me.rdoTxt.Checked = True
        Me.rdoTxt.Location = New System.Drawing.Point(6, 19)
        Me.rdoTxt.Name = "rdoTxt"
        Me.rdoTxt.Size = New System.Drawing.Size(39, 17)
        Me.rdoTxt.TabIndex = 9
        Me.rdoTxt.TabStop = True
        Me.rdoTxt.Text = ".txt"
        Me.rdoTxt.UseVisualStyleBackColor = True
        '
        'grpExportType
        '
        Me.grpExportType.Controls.Add(Me.rdoTxt)
        Me.grpExportType.Controls.Add(Me.rdoCsv)
        Me.grpExportType.Location = New System.Drawing.Point(25, 71)
        Me.grpExportType.Name = "grpExportType"
        Me.grpExportType.Size = New System.Drawing.Size(66, 70)
        Me.grpExportType.TabIndex = 10
        Me.grpExportType.TabStop = False
        Me.grpExportType.Text = "Export as"
        '
        'cbxRows
        '
        Me.cbxRows.FormattingEnabled = True
        Me.cbxRows.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cbxRows.Location = New System.Drawing.Point(109, 101)
        Me.cbxRows.Name = "cbxRows"
        Me.cbxRows.Size = New System.Drawing.Size(50, 21)
        Me.cbxRows.TabIndex = 11
        Me.cbxRows.Text = "6"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Rows per item"
        '
        'chkAltRowDelete
        '
        Me.chkAltRowDelete.AutoSize = True
        Me.chkAltRowDelete.Checked = True
        Me.chkAltRowDelete.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAltRowDelete.Location = New System.Drawing.Point(323, 80)
        Me.chkAltRowDelete.Name = "chkAltRowDelete"
        Me.chkAltRowDelete.Size = New System.Drawing.Size(134, 17)
        Me.chkAltRowDelete.TabIndex = 13
        Me.chkAltRowDelete.Text = "Delete alternating rows"
        Me.chkAltRowDelete.UseVisualStyleBackColor = True
        '
        'lblColomn
        '
        Me.lblColomn.AutoSize = True
        Me.lblColomn.Location = New System.Drawing.Point(189, 81)
        Me.lblColomn.Name = "lblColomn"
        Me.lblColomn.Size = New System.Drawing.Size(114, 13)
        Me.lblColomn.TabIndex = 15
        Me.lblColomn.Text = "Characters per Column"
        '
        'txtColumn
        '
        Me.txtColumn.Location = New System.Drawing.Point(221, 101)
        Me.txtColumn.Name = "txtColumn"
        Me.txtColumn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtColumn.Size = New System.Drawing.Size(48, 20)
        Me.txtColumn.TabIndex = 16
        Me.txtColumn.Text = "53"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 152)
        Me.Controls.Add(Me.txtColumn)
        Me.Controls.Add(Me.lblColomn)
        Me.Controls.Add(Me.chkAltRowDelete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxRows)
        Me.Controls.Add(Me.grpExportType)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.btnBrowseTo)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.btnBrowseFrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Name = "Form1"
        Me.Text = "10 x 3 To CSV"
        Me.grpExportType.ResumeLayout(False)
        Me.grpExportType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBrowseFrom As Button
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents txtTo As TextBox
    Friend WithEvents btnBrowseTo As Button
    Friend WithEvents rdoCsv As RadioButton
    Friend WithEvents rdoTxt As RadioButton
    Friend WithEvents grpExportType As GroupBox
    Friend WithEvents cbxRows As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkAltRowDelete As CheckBox
    Friend WithEvents lblColomn As Label
    Friend WithEvents txtColumn As TextBox
End Class
