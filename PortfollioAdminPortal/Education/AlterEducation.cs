using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfollioAdminPortal
{
    public partial class AlterEducation : AlterRecordForm<Education>
    {
        public AlterEducation(string sessionId, HttpClient client) : base(sessionId, client)
        {
            if(txtSchool is null) InitializeComponent();
        }

        public AlterEducation(string sessionId, HttpClient client, Education education) : base(sessionId, client, education)
        {
            if (txtSchool is null) InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            HandleSubmit();
        }

        private void StartDateUpdated(object sender, EventArgs e)
        {
            datePickEnd.MinDate = datePickStart.Value;
        }

        private void EndDateUpdated(object sender, EventArgs e)
        {
            datePickStart.MaxDate = datePickEnd.Value;
        }

        protected override IServerEntity PackEntity()
        {
            return new Education("-1", txtSchool.Text, txtCourse.Text, datePickStart.Text, datePickEnd.Text);
        }

        protected override void UnpackEntity(Education entity)
        {
            if (txtSchool is null) InitializeComponent();
            id = entity.id;
            txtSchool.Text = entity.school;
            txtCourse.Text = entity.course;
            datePickStart.Text = entity.start_date;
            datePickEnd.Text = entity.end_date;
        }
    }
}
