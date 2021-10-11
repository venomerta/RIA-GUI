<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConfiguration
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
        Me.labelL_time_count = New System.Windows.Forms.Label()
        Me.value_time_count = New System.Windows.Forms.NumericUpDown()
        Me.label_de = New System.Windows.Forms.Label()
        Me.label_lld = New System.Windows.Forms.Label()
        Me.value_de = New System.Windows.Forms.NumericUpDown()
        Me.value_lld = New System.Windows.Forms.NumericUpDown()
        Me.checkbox_duplo = New System.Windows.Forms.CheckBox()
        Me.btn_setconfig = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_numSample = New System.Windows.Forms.Label()
        Me.btn_setdefault = New System.Windows.Forms.Button()
        CType(Me.value_time_count, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.value_de, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.value_lld, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelL_time_count
        '
        Me.labelL_time_count.AutoSize = True
        Me.labelL_time_count.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.labelL_time_count.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labelL_time_count.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelL_time_count.Location = New System.Drawing.Point(54, 80)
        Me.labelL_time_count.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelL_time_count.Name = "labelL_time_count"
        Me.labelL_time_count.Size = New System.Drawing.Size(242, 39)
        Me.labelL_time_count.TabIndex = 0
        Me.labelL_time_count.Text = "Counting Time"
        '
        'value_time_count
        '
        Me.value_time_count.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.value_time_count.Location = New System.Drawing.Point(403, 80)
        Me.value_time_count.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.value_time_count.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.value_time_count.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.value_time_count.Name = "value_time_count"
        Me.value_time_count.Size = New System.Drawing.Size(132, 46)
        Me.value_time_count.TabIndex = 1
        Me.value_time_count.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'label_de
        '
        Me.label_de.AutoSize = True
        Me.label_de.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_de.Location = New System.Drawing.Point(54, 220)
        Me.label_de.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label_de.Name = "label_de"
        Me.label_de.Size = New System.Drawing.Size(59, 39)
        Me.label_de.TabIndex = 0
        Me.label_de.Text = "dE"
        '
        'label_lld
        '
        Me.label_lld.AutoSize = True
        Me.label_lld.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label_lld.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_lld.Location = New System.Drawing.Point(54, 150)
        Me.label_lld.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label_lld.Name = "label_lld"
        Me.label_lld.Size = New System.Drawing.Size(80, 39)
        Me.label_lld.TabIndex = 0
        Me.label_lld.Text = "LLD"
        '
        'value_de
        '
        Me.value_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.value_de.Location = New System.Drawing.Point(403, 219)
        Me.value_de.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.value_de.Maximum = New Decimal(New Integer() {1093, 0, 0, 0})
        Me.value_de.Name = "value_de"
        Me.value_de.Size = New System.Drawing.Size(132, 46)
        Me.value_de.TabIndex = 1
        Me.value_de.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'value_lld
        '
        Me.value_lld.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.value_lld.Location = New System.Drawing.Point(403, 148)
        Me.value_lld.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.value_lld.Maximum = New Decimal(New Integer() {1093, 0, 0, 0})
        Me.value_lld.Name = "value_lld"
        Me.value_lld.Size = New System.Drawing.Size(132, 46)
        Me.value_lld.TabIndex = 1
        Me.value_lld.Value = New Decimal(New Integer() {80, 0, 0, 0})
        '
        'checkbox_duplo
        '
        Me.checkbox_duplo.AutoSize = True
        Me.checkbox_duplo.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkbox_duplo.Location = New System.Drawing.Point(550, 80)
        Me.checkbox_duplo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.checkbox_duplo.Name = "checkbox_duplo"
        Me.checkbox_duplo.Size = New System.Drawing.Size(126, 43)
        Me.checkbox_duplo.TabIndex = 2
        Me.checkbox_duplo.Text = "Duplo"
        Me.checkbox_duplo.UseVisualStyleBackColor = True
        '
        'btn_setconfig
        '
        Me.btn_setconfig.BackColor = System.Drawing.Color.Blue
        Me.btn_setconfig.FlatAppearance.BorderSize = 0
        Me.btn_setconfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_setconfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_setconfig.ForeColor = System.Drawing.Color.White
        Me.btn_setconfig.Location = New System.Drawing.Point(403, 427)
        Me.btn_setconfig.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_setconfig.Name = "btn_setconfig"
        Me.btn_setconfig.Size = New System.Drawing.Size(189, 55)
        Me.btn_setconfig.TabIndex = 3
        Me.btn_setconfig.Text = "SET"
        Me.btn_setconfig.UseVisualStyleBackColor = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(403, 283)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(132, 46)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'lbl_numSample
        '
        Me.lbl_numSample.AutoSize = True
        Me.lbl_numSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_numSample.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numSample.Location = New System.Drawing.Point(54, 290)
        Me.lbl_numSample.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_numSample.Name = "lbl_numSample"
        Me.lbl_numSample.Size = New System.Drawing.Size(314, 39)
        Me.lbl_numSample.TabIndex = 0
        Me.lbl_numSample.Text = "Number Of Sample"
        '
        'btn_setdefault
        '
        Me.btn_setdefault.BackColor = System.Drawing.Color.Blue
        Me.btn_setdefault.FlatAppearance.BorderSize = 0
        Me.btn_setdefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_setdefault.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_setdefault.ForeColor = System.Drawing.Color.White
        Me.btn_setdefault.Location = New System.Drawing.Point(403, 368)
        Me.btn_setdefault.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_setdefault.Name = "btn_setdefault"
        Me.btn_setdefault.Size = New System.Drawing.Size(189, 55)
        Me.btn_setdefault.TabIndex = 3
        Me.btn_setdefault.Text = "DEFAULT"
        Me.btn_setdefault.UseVisualStyleBackColor = False
        '
        'FormConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(810, 718)
        Me.Controls.Add(Me.btn_setdefault)
        Me.Controls.Add(Me.btn_setconfig)
        Me.Controls.Add(Me.checkbox_duplo)
        Me.Controls.Add(Me.value_lld)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.value_de)
        Me.Controls.Add(Me.value_time_count)
        Me.Controls.Add(Me.label_lld)
        Me.Controls.Add(Me.lbl_numSample)
        Me.Controls.Add(Me.label_de)
        Me.Controls.Add(Me.labelL_time_count)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormConfiguration"
        Me.Text = "Configuration"
        CType(Me.value_time_count, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.value_de, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.value_lld, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelL_time_count As Label
    Friend WithEvents value_time_count As NumericUpDown
    Friend WithEvents label_de As Label
    Friend WithEvents label_lld As Label
    Friend WithEvents value_de As NumericUpDown
    Friend WithEvents value_lld As NumericUpDown
    Friend WithEvents checkbox_duplo As CheckBox
    Friend WithEvents btn_setconfig As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents lbl_numSample As Label
    Friend WithEvents btn_setdefault As Button
End Class
