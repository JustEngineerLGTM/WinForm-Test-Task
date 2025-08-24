using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using TestTaskForm.Models;
using TestTaskForm.Services;

namespace TestTaskForm
{
    public partial class Form1 : Form
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IReportRepository _reportRepository;
        private List<Person> _allEmployees = new();

        public Form1(IServiceProvider provider)
        {
            _employeeRepository = provider.GetRequiredService<IEmployeeRepository>();
            _reportRepository = provider.GetRequiredService<IReportRepository>();
            InitializeComponent();
            Load += Form1_Load;

            dateTimePickerFrom.ValueChanged += ReportFiltersChanged;
            dateTimePickerTo.ValueChanged += ReportFiltersChanged;
            comboBoxStatusReport.SelectedIndexChanged += ReportFiltersChanged;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
            InitFilters();
            InitReportStatusCombo();
            ApplyFilters();
        }

        private async Task LoadDataAsync()
        {
            _allEmployees.Clear();
            await foreach (var p in _employeeRepository.GetAllAsync())
                _allEmployees.Add(p);
        }

        private void InitReportStatusCombo()
        {
            var statusList = _allEmployees
                .Where(p => true)
                .GroupBy(p => p.Status.Id)
                .Select(g => g.First().Status)
                .ToList();

            comboBoxStatusReport.DataSource = statusList;
            comboBoxStatusReport.DisplayMember = "Name";
            comboBoxStatusReport.ValueMember = "Id";
        }

        private async void ReportFiltersChanged(object? sender, EventArgs e)
        {
            var from = dateTimePickerFrom.Value.Date;
            var to = dateTimePickerTo.Value.Date;

            var statusId = 0;
            if (comboBoxStatusReport.SelectedItem is Status status)
                statusId = status.Id;

            var count = await _reportRepository.GetCountAsync(statusId, from, to);

            labelResult.Text = $"Сотрудников: {count}";
        }

        private void InitFilters()
        {
            var statusList = _allEmployees
                .Where(p => true)
                .GroupBy(p => p.Status.Id)
                .Select(g => g.First().Status)
                .ToList();
            statusList.Insert(0, new Status
            {
                Id = 0, Name = "Все"
            });
            comboBoxStatus.DataSource = statusList;
            comboBoxStatus.DisplayMember = "Name";
            comboBoxStatus.ValueMember = "Id";

            var depList = _allEmployees
                .Where(p => true)
                .GroupBy(p => p.Dep.Id)
                .Select(g => g.First().Dep)
                .ToList();
            depList.Insert(0, new Dep
            {
                Id = 0, Name = "Все"
            });
            comboBoxDep.DataSource = depList;
            comboBoxDep.DisplayMember = "Name";
            comboBoxDep.ValueMember = "Id";

            var postList = _allEmployees
                .Where(p => true)
                .GroupBy(p => p.Post.Id)
                .Select(g => g.First().Post)
                .ToList();
            postList.Insert(0, new Post
            {
                Id = 0, Name = "Все"
            });
            comboBoxPost.DataSource = postList;
            comboBoxPost.DisplayMember = "Name";
            comboBoxPost.ValueMember = "Id";

            comboBoxStatus.SelectedIndexChanged += (s, e) => ApplyFilters();
            comboBoxDep.SelectedIndexChanged += (s, e) => ApplyFilters();
            comboBoxPost.SelectedIndexChanged += (s, e) => ApplyFilters();
            textboxLastName.TextChanged += (s, e) => ApplyFilters();
        }


        private void ApplyFilters()
        {
            var filtered = _allEmployees.AsEnumerable();

            if (comboBoxStatus.SelectedItem is Status status && status.Id != 0)
                filtered = filtered.Where(p => p.StatusId == status.Id);

            if (comboBoxDep.SelectedItem is Dep dep && dep.Id != 0)
                filtered = filtered.Where(p => p.DepId == dep.Id);

            if (comboBoxPost.SelectedItem is Post post && post.Id != 0)
                filtered = filtered.Where(p => p.PostId == post.Id);

            var lastNameFilter = textboxLastName.Text.Trim();
            if (!string.IsNullOrEmpty(lastNameFilter))
                filtered = filtered.Where(p
                    => p.LastName?.Contains(lastNameFilter, StringComparison.OrdinalIgnoreCase) == true);

            UpdateGrid(filtered.ToList());
        }

        private void UpdateGrid(List<Person> employees)
        {
            var dt = new DataTable();
            dt.Columns.Add("ФИО");
            dt.Columns.Add("Статус");
            dt.Columns.Add("Отдел");
            dt.Columns.Add("Должность");
            dt.Columns.Add("Дата приема");
            dt.Columns.Add("Дата увольнения");

            foreach (var p in employees)
            {
                dt.Rows.Add(
                    $"{p.LastName} {p.FirstName[0]}. {p.SecondName[0]}.",
                    p.Status?.Name ?? "",
                    p.Dep?.Name ?? "",
                    p.Post?.Name ?? "",
                    p.DateEmploy?.ToString("yyyy-MM-dd") ?? "",
                    p.DateUneploy?.ToString("yyyy-MM-dd") ?? ""
                );
            }

            dataGridView_employees.DataSource = dt;

            foreach (DataGridViewColumn column in dataGridView_employees.Columns)
                column.SortMode = DataGridViewColumnSortMode.Automatic;
        }

    }
}