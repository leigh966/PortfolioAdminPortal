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
    public partial class AlterEmployment : AlterRecordForm<Employment>
    {
        public AlterEmployment(string sessionId, HttpClient client) : base(sessionId, client)
        {
            if(txtEmployer is null) InitializeComponent();
        }

        public AlterEmployment(string sessionId, HttpClient client, Employment employment) : base(sessionId, client, employment)
        {
            if (txtEmployer is null) InitializeComponent();
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
            return new Employment("-1", txtEmployer.Text, txtTitle.Text, datePickStart.Text, datePickEnd.Text);
        }

        protected override void UnpackEntity(Employment entity)
        {
            if (txtEmployer is null) InitializeComponent();
            id = entity.id;
            txtEmployer.Text = entity.employer;
            txtTitle.Text = entity.job_title;
            datePickStart.Text = entity.start_date;
            datePickEnd.Text = entity.end_date;
        }
    }
}
