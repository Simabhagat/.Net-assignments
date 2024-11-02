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
        labelPrompt = New Label()
        textBoxTerms = New TextBox()
        buttonGenerate = New Button()
        listBoxSequence = New ListBox()
        SuspendLayout()
        ' 
        ' labelPrompt
        ' 
        labelPrompt.AutoSize = True
        labelPrompt.Location = New Point(10, 20)
        labelPrompt.Name = "labelPrompt"
        labelPrompt.Size = New Size(160, 20)
        labelPrompt.TabIndex = 0
        labelPrompt.Text = "Enter number of terms:"
        ' 
        ' textBoxTerms
        ' 
        textBoxTerms.Location = New Point(180, 20)
        textBoxTerms.Name = "textBoxTerms"
        textBoxTerms.Size = New Size(125, 27)
        textBoxTerms.TabIndex = 1
        ' 
        ' buttonGenerate
        ' 
        buttonGenerate.Location = New Point(10, 60)
        buttonGenerate.Name = "buttonGenerate"
        buttonGenerate.Size = New Size(94, 29)
        buttonGenerate.TabIndex = 2
        buttonGenerate.Text = "Generate"
        buttonGenerate.UseVisualStyleBackColor = True
        ' 
        ' listBoxSequence
        ' 
        listBoxSequence.FormattingEnabled = True
        listBoxSequence.Location = New Point(10, 100)
        listBoxSequence.MaximumSize = New Size(260, 150)
        listBoxSequence.MinimumSize = New Size(260, 150)
        listBoxSequence.Name = "listBoxSequence"
        listBoxSequence.Size = New Size(260, 144)
        listBoxSequence.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(listBoxSequence)
        Controls.Add(buttonGenerate)
        Controls.Add(textBoxTerms)
        Controls.Add(labelPrompt)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labelPrompt As Label
    Friend WithEvents textBoxTerms As TextBox
    Friend WithEvents buttonGenerate As Button
    Friend WithEvents listBoxSequence As ListBox

End Class
