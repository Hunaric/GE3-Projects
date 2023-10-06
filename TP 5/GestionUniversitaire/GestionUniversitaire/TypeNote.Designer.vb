<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TypeNote
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_supp = New System.Windows.Forms.Button()
        Me.Btn_selection = New System.Windows.Forms.Button()
        Me.Btn_ajout_type_note = New System.Windows.Forms.Button()
        Me.Tableau_type_note = New System.Windows.Forms.DataGridView()
        Me.nom_type_note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_type_note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type_note_champs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Tableau_type_note, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(124, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 42)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "TYPE DE NOTE"
        '
        'Btn_supp
        '
        Me.Btn_supp.Location = New System.Drawing.Point(373, 210)
        Me.Btn_supp.Name = "Btn_supp"
        Me.Btn_supp.Size = New System.Drawing.Size(83, 23)
        Me.Btn_supp.TabIndex = 34
        Me.Btn_supp.Text = "SUPPRIMER"
        Me.Btn_supp.UseVisualStyleBackColor = True
        '
        'Btn_selection
        '
        Me.Btn_selection.Location = New System.Drawing.Point(373, 166)
        Me.Btn_selection.Name = "Btn_selection"
        Me.Btn_selection.Size = New System.Drawing.Size(84, 23)
        Me.Btn_selection.TabIndex = 33
        Me.Btn_selection.Text = "CHOISIR"
        Me.Btn_selection.UseVisualStyleBackColor = True
        '
        'Btn_ajout_type_note
        '
        Me.Btn_ajout_type_note.Location = New System.Drawing.Point(373, 98)
        Me.Btn_ajout_type_note.Name = "Btn_ajout_type_note"
        Me.Btn_ajout_type_note.Size = New System.Drawing.Size(83, 23)
        Me.Btn_ajout_type_note.TabIndex = 32
        Me.Btn_ajout_type_note.Text = "AJOUTER"
        Me.Btn_ajout_type_note.UseVisualStyleBackColor = True
        '
        'Tableau_type_note
        '
        Me.Tableau_type_note.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Tableau_type_note.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tableau_type_note.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nom_type_note, Me.num_type_note})
        Me.Tableau_type_note.Location = New System.Drawing.Point(20, 166)
        Me.Tableau_type_note.Name = "Tableau_type_note"
        Me.Tableau_type_note.Size = New System.Drawing.Size(310, 150)
        Me.Tableau_type_note.TabIndex = 31
        '
        'nom_type_note
        '
        Me.nom_type_note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nom_type_note.HeaderText = "TYPE DE NOTE"
        Me.nom_type_note.Name = "nom_type_note"
        '
        'num_type_note
        '
        Me.num_type_note.HeaderText = "Num_type"
        Me.num_type_note.Name = "num_type_note"
        Me.num_type_note.Visible = False
        '
        'type_note_champs
        '
        Me.type_note_champs.Location = New System.Drawing.Point(119, 100)
        Me.type_note_champs.Name = "type_note_champs"
        Me.type_note_champs.Size = New System.Drawing.Size(140, 20)
        Me.type_note_champs.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "TYPE DE NOTE :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(145, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(275, 26)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Dans le cas d'une modification, veuillez sélection un type" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de note avant de le r" &
    "ectifier dans le champs de saisie"
        '
        'TypeNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 406)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btn_supp)
        Me.Controls.Add(Me.Btn_selection)
        Me.Controls.Add(Me.Btn_ajout_type_note)
        Me.Controls.Add(Me.Tableau_type_note)
        Me.Controls.Add(Me.type_note_champs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "TypeNote"
        Me.Text = "TypeNote"
        CType(Me.Tableau_type_note, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_supp As Button
    Friend WithEvents Btn_selection As Button
    Friend WithEvents Btn_ajout_type_note As Button
    Friend WithEvents Tableau_type_note As DataGridView
    Friend WithEvents nom_type_note As DataGridViewTextBoxColumn
    Friend WithEvents num_type_note As DataGridViewTextBoxColumn
    Friend WithEvents type_note_champs As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
