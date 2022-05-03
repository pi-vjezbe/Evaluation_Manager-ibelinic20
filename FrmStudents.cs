﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;

namespace Evaluation_Manager
{
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
        }

		private void FrmStudents_Load(object sender, EventArgs e) {
            List<Student> students = StudentRepository.GetStudents();
            dgvStudents.DataSource = students;
		}
	}
}
