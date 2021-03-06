﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace DesktopDoctor
{
    public partial class MedicinesForm : Form
    {

        DesktopDoctorDatabaseEntities db = new DesktopDoctorDatabaseEntities();

        public MedicinesForm()
        {
            InitializeComponent();
            medicinesBindingSource.DataSource = db.Medicines.ToList();
        }

        private void AddMedicineButton_Click(object sender, EventArgs e)
        {
            EditMedicineForm medicineForm = new EditMedicineForm(new Medicine())
            {
                MdiParent = MdiParent
            };
            medicineForm.Show();
            medicineForm.Dock = DockStyle.Fill;
            Close();
        }
    }
}
