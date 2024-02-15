<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        txtFirstnumber = New TextBox()
        txtSecondnumber = New TextBox()
        btndivide = New Button()
        lblresult = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(312, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 0
        Label1.Text = "First number"
        ' 
        ' txtFirstnumber
        ' 
        txtFirstnumber.Location = New Point(312, 65)
        txtFirstnumber.Name = "txtFirstnumber"
        txtFirstnumber.Size = New Size(100, 23)
        txtFirstnumber.TabIndex = 2
        ' 
        ' txtSecondnumber
        ' 
        txtSecondnumber.Location = New Point(312, 119)
        txtSecondnumber.Name = "txtSecondnumber"
        txtSecondnumber.Size = New Size(100, 23)
        txtSecondnumber.TabIndex = 3
        ' 
        ' btndivide
        ' 
        btndivide.Location = New Point(312, 159)
        btndivide.Name = "btndivide"
        btndivide.Size = New Size(75, 23)
        btndivide.TabIndex = 4
        btndivide.Text = "answer"
        btndivide.UseVisualStyleBackColor = True
        ' 
        ' lblresult
        ' 
        lblresult.AutoSize = True
        lblresult.Location = New Point(314, 205)
        lblresult.Name = "lblresult"
        lblresult.Size = New Size(41, 15)
        lblresult.TabIndex = 5
        lblresult.Text = "Label3"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(312, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 15)
        Label2.TabIndex = 6
        Label2.Text = "Second number"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(493, 450)
        Controls.Add(Label2)
        Controls.Add(lblresult)
        Controls.Add(btndivide)
        Controls.Add(txtSecondnumber)
        Controls.Add(txtFirstnumber)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstnumber As TextBox
    Friend WithEvents txtSecondnumber As TextBox
    Friend WithEvents btndivide As Button
    Friend WithEvents lblresult As Label
    Friend WithEvents Label2 As Label
End Class
