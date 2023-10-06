<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnrEtudiant
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
        Me.Btn_enr = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nom_ = New System.Windows.Forms.Label()
        Me.champs_nom = New System.Windows.Forms.TextBox()
        Me.champs_prenom = New System.Windows.Forms.TextBox()
        Me.champs_lieu = New System.Windows.Forms.TextBox()
        Me.champs_matr = New System.Windows.Forms.TextBox()
        Me.combo_classe = New System.Windows.Forms.ComboBox()
        Me.champs_sexe = New System.Windows.Forms.GroupBox()
        Me.champs_sexe_fem = New System.Windows.Forms.RadioButton()
        Me.champs_sexe_masc = New System.Windows.Forms.RadioButton()
        Me.champs_date = New System.Windows.Forms.DateTimePicker()
        Me.champs_sexe.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_enr
        '
        Me.Btn_enr.Location = New System.Drawing.Point(239, 299)
        Me.Btn_enr.Name = "Btn_enr"
        Me.Btn_enr.Size = New System.Drawing.Size(193, 23)
        Me.Btn_enr.TabIndex = 59
        Me.Btn_enr.Text = "ENREGISTRER ETUDIANT"
        Me.Btn_enr.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(449, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 20)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "CLASSE :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(449, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "NUM :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "PRENOM :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "SEXE :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 20)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "DATE DE NAISSANCE :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "LIEU DE NAISSANCE :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(220, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(212, 42)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "ETUDIANT"
        '
        'nom_
        '
        Me.nom_.AutoSize = True
        Me.nom_.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom_.Location = New System.Drawing.Point(50, 75)
        Me.nom_.Name = "nom_"
        Me.nom_.Size = New System.Drawing.Size(53, 20)
        Me.nom_.TabIndex = 44
        Me.nom_.Text = "NOM :"
        '
        'champs_nom
        '
        Me.champs_nom.Location = New System.Drawing.Point(243, 77)
        Me.champs_nom.Name = "champs_nom"
        Me.champs_nom.Size = New System.Drawing.Size(138, 20)
        Me.champs_nom.TabIndex = 61
        '
        'champs_prenom
        '
        Me.champs_prenom.Location = New System.Drawing.Point(243, 115)
        Me.champs_prenom.Name = "champs_prenom"
        Me.champs_prenom.Size = New System.Drawing.Size(138, 20)
        Me.champs_prenom.TabIndex = 62
        '
        'champs_lieu
        '
        Me.champs_lieu.Location = New System.Drawing.Point(243, 220)
        Me.champs_lieu.Name = "champs_lieu"
        Me.champs_lieu.Size = New System.Drawing.Size(138, 20)
        Me.champs_lieu.TabIndex = 65
        '
        'champs_matr
        '
        Me.champs_matr.Location = New System.Drawing.Point(539, 75)
        Me.champs_matr.Name = "champs_matr"
        Me.champs_matr.ReadOnly = True
        Me.champs_matr.Size = New System.Drawing.Size(138, 20)
        Me.champs_matr.TabIndex = 66
        '
        'combo_classe
        '
        Me.combo_classe.FormattingEnabled = True
        Me.combo_classe.Location = New System.Drawing.Point(539, 115)
        Me.combo_classe.Name = "combo_classe"
        Me.combo_classe.Size = New System.Drawing.Size(138, 21)
        Me.combo_classe.TabIndex = 67
        '
        'champs_sexe
        '
        Me.champs_sexe.Controls.Add(Me.champs_sexe_fem)
        Me.champs_sexe.Controls.Add(Me.champs_sexe_masc)
        Me.champs_sexe.Location = New System.Drawing.Point(243, 141)
        Me.champs_sexe.Name = "champs_sexe"
        Me.champs_sexe.Size = New System.Drawing.Size(138, 31)
        Me.champs_sexe.TabIndex = 68
        Me.champs_sexe.TabStop = False
        '
        'champs_sexe_fem
        '
        Me.champs_sexe_fem.AutoSize = True
        Me.champs_sexe_fem.Location = New System.Drawing.Point(89, 8)
        Me.champs_sexe_fem.Name = "champs_sexe_fem"
        Me.champs_sexe_fem.Size = New System.Drawing.Size(31, 17)
        Me.champs_sexe_fem.TabIndex = 1
        Me.champs_sexe_fem.TabStop = True
        Me.champs_sexe_fem.Text = "F"
        Me.champs_sexe_fem.UseVisualStyleBackColor = True
        '
        'champs_sexe_masc
        '
        Me.champs_sexe_masc.AutoSize = True
        Me.champs_sexe_masc.Checked = True
        Me.champs_sexe_masc.Location = New System.Drawing.Point(15, 8)
        Me.champs_sexe_masc.Name = "champs_sexe_masc"
        Me.champs_sexe_masc.Size = New System.Drawing.Size(34, 17)
        Me.champs_sexe_masc.TabIndex = 0
        Me.champs_sexe_masc.TabStop = True
        Me.champs_sexe_masc.Text = "M"
        Me.champs_sexe_masc.UseVisualStyleBackColor = True
        '
        'champs_date
        '
        Me.champs_date.Location = New System.Drawing.Point(243, 185)
        Me.champs_date.Name = "champs_date"
        Me.champs_date.Size = New System.Drawing.Size(138, 20)
        Me.champs_date.TabIndex = 69
        '
        'EnrEtudiant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 459)
        Me.Controls.Add(Me.champs_date)
        Me.Controls.Add(Me.champs_sexe)
        Me.Controls.Add(Me.combo_classe)
        Me.Controls.Add(Me.champs_matr)
        Me.Controls.Add(Me.champs_lieu)
        Me.Controls.Add(Me.champs_prenom)
        Me.Controls.Add(Me.champs_nom)
        Me.Controls.Add(Me.Btn_enr)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nom_)
        Me.Name = "EnrEtudiant"
        Me.Text = "EnrEtudiant"
        Me.champs_sexe.ResumeLayout(False)
        Me.champs_sexe.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_enr As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nom_ As Label
    Friend WithEvents champs_nom As TextBox
    Friend WithEvents champs_prenom As TextBox
    Friend WithEvents champs_lieu As TextBox
    Friend WithEvents champs_matr As TextBox
    Friend WithEvents combo_classe As ComboBox
    Friend WithEvents champs_sexe As GroupBox
    Friend WithEvents champs_sexe_fem As RadioButton
    Friend WithEvents champs_sexe_masc As RadioButton
    Friend WithEvents champs_date As DateTimePicker
End Class
