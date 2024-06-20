using FinalProject.Core.Context;
using FinalProject.Core.Entities;
using FinalProject.DataManager.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinalProject.UI
{
    public partial class MainForm : Form
    {
        private CoachRep _coachRepos = new CoachRep();
        private CoachContractRep _coachContractRepos = new CoachContractRep();
        private FootballTeamRepos _footballTeamRepos = new FootballTeamRepos();
        private PlayerRep _playerRepos = new PlayerRep();
        private PlayerContractRep _playerContractRepos = new PlayerContractRep();
        private PlayerTransferRep _playerTransferRepos = new PlayerTransferRep();
        private PositionRep _positionRep = new PositionRep();
        public MainForm()
        {
            InitializeComponent();
            listBoxCoaches.Items.AddRange(_coachRepos.GetAll().ToArray());
            listBoxCoachesContracts.Items.AddRange(_coachContractRepos.GetAll().ToArray());
            listBoxFootballTeams.Items.AddRange(_footballTeamRepos.GetAll().ToArray());
            listBoxPlayers.Items.AddRange(_playerRepos.GetAll().ToArray());
            listBoxPlayersContracts.Items.AddRange(_playerContractRepos.GetAll().ToArray());
            listBoxPlayersTransfers.Items.AddRange(_playerTransferRepos.GetAll().ToArray());
            listBoxPositions.Items.AddRange(_positionRep.GetAll().ToArray());

            checkRole(PersonalData.IsAdmin);


            var coaches = _coachRepos.GetAll();


            /* comboBoxPlayerContractPlayer.DataSource = listBoxPlayers.Items.Cast<Player>().ToList();
             comboBoxPlayerContractPlayer.DisplayMember = "FullName";

             comboBoxPlayerContractFootballTeam.DataSource = listBoxFootballTeams.Items.Cast<FootballTeam>().ToList();
             comboBoxPlayerContractFootballTeam.DisplayMember = "FullName";*/

            comboBoxContractCoaches.DataSource = coaches.ToList();
            comboBoxContractCoaches.DisplayMember = "FullName";
            comboBoxContractCoaches.ValueMember = "Id";
        }

        private void checkRole(bool role)
        {
            switch (role)
            {
                case (true):

                    MessageBox.Show($"Welcome {PersonalData.Login}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case (false):

                    MessageBox.Show($"Welcome {PersonalData.Login}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                default:
                    MessageBox.Show("User hasn't founded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void buttonAddCoach_Click(object sender, EventArgs e)
        {
            string fullName = textBoxCoachFullName.Text;
            int age = Convert.ToInt32(textBoxCoachAge.Text);
            int wonTrofies = Convert.ToInt32(textBoxCoachWonTrofies.Text);
            int currentMatches = Convert.ToInt32(textBoxCoachCurrentMatches.Text);
            int drawnMatches = Convert.ToInt32(textBoxDrawnMatches.Text);
            int wonMatches = Convert.ToInt32(textBoxWonMatches.Text);
            int loosedMatches = Convert.ToInt32(textBoxLoosedMatches.Text);

            Coach newCoach = new Coach
            {
                FullName = fullName,
                Age = age,
                WonTrofies = wonTrofies,
                CurrentMatchesAmount = currentMatches,
                DrawnMatches = drawnMatches,
                WonMatches = wonMatches,
                LoosedMatches = loosedMatches
            };

            int addedCoachId = _coachRepos.Add(newCoach);


            if (addedCoachId > 0)
            {
                MessageBox.Show($"Coach with ID {addedCoachId} has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UpdateCoachList();
            }
            else
            {
                MessageBox.Show("Failed to add coach.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCoachList()
        {
            listBoxCoaches.Items.Clear();
            listBoxCoaches.Items.AddRange(_coachRepos.GetAll().ToArray());
        }

        private void listBoxCoaches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCoaches.SelectedIndex != -1)
            {

                Coach selectedCoach = (Coach)listBoxCoaches.SelectedItem;


                textBoxCoachFullName.Text = selectedCoach.FullName;
                textBoxCoachAge.Text = selectedCoach.Age.ToString();
                textBoxCoachWonTrofies.Text = selectedCoach.WonTrofies.ToString();
                textBoxCoachCurrentMatches.Text = selectedCoach.CurrentMatchesAmount.ToString();
                textBoxDrawnMatches.Text = selectedCoach.DrawnMatches.ToString();
                textBoxWonMatches.Text = selectedCoach.WonMatches.ToString();
                textBoxLoosedMatches.Text = selectedCoach.LoosedMatches.ToString();
            }
        }

        private void buttonAddCoachContract_Click(object sender, EventArgs e)
        {
            int coachId = Convert.ToInt32(comboBoxContractCoaches.SelectedValue);


            if (comboBoxContractCoaches.SelectedIndex == -1)
            {
                MessageBox.Show("Choose coach", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var ctx = new FootballTeamContext();

            var coach = ctx.Coaches.First(x => x.Id == Convert.ToInt32(comboBoxContractCoaches.SelectedValue));

            ctx.CoachContracts.Add(new CoachContract
            {
                Coach = coach,
                StartDate = dateTimePickerDateStart.Value,
                EndDate = dateTimePickerDateEnd.Value,
                Salary = Convert.ToInt32(textBoxContractSalary.Text)
            });

            ctx.SaveChanges();

            UpdateCoachContractList();
        }

        private void listBoxCoachesContracts_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectedContract = (CoachContract)listBoxCoachesContracts.SelectedItem;


            if (selectedContract != null)
            {

                textBoxContractSalary.Text = selectedContract.Salary.ToString();
                comboBoxContractCoaches.SelectedValue = selectedContract.Coach.Id;
                dateTimePickerDateStart.Value = selectedContract.StartDate;
                dateTimePickerDateEnd.Value = selectedContract.EndDate;
            }
        }

        private void UpdateCoachContractList()
        {
            listBoxCoachesContracts.Items.Clear();
            listBoxCoachesContracts.Items.AddRange(_coachContractRepos.GetAll().ToArray());

        }


        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(textBoxPlayerAge.Text);
            string fullName = textBoxPlayerFullName.Text;
            string workingLeg = textBoxPlayerWorkingLeg.Text;
            bool isCaptain = checkBoxPlayerIsCaptain.Checked;
            int goals = Convert.ToInt32(textBoxPlayerGoals.Text);
            int assists = Convert.ToInt32(textBoxAssists.Text);

            Player newPlayer = new Player
            {
                Age = age,
                FullName = fullName,
                WorkingLeg = workingLeg,
                IsCaptain = isCaptain,
                Goals = goals,
                Assists = assists
            };

            var playerRep = new PlayerRep();
            int addedPlayerId = playerRep.Add(newPlayer);

            UpdatePlayerList();

            if (addedPlayerId > 0)
            {
                MessageBox.Show($"Player with ID {addedPlayerId} has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add player.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePlayerList()
        {
            listBoxPlayers.Items.Clear();
            listBoxPlayers.Items.AddRange(_playerRepos.GetAll().ToArray());

        }

        private void listBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem != null)
            {

                Player selectedPlayer = (Player)listBoxPlayers.SelectedItem;


                textBoxPlayerAge.Text = selectedPlayer.Age.ToString();
                textBoxPlayerFullName.Text = selectedPlayer.FullName;
                checkBoxPlayerIsCaptain.Checked = selectedPlayer.IsCaptain;
                textBoxPlayerWorkingLeg.Text = selectedPlayer.WorkingLeg;
                textBoxPlayerGoals.Text = selectedPlayer.Goals.ToString();
                textBoxAssists.Text = selectedPlayer.Assists.ToString();
            }
        }

        private void buttonAddPosition_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPosition.Text))
            {
                MessageBox.Show("Введіть назву посади", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Position newPosition = new Position
            {
                Name = textBoxPosition.Text

            };

            var positionRep = new PositionRep();
            int addedPositionId = positionRep.Add(newPosition);


            if (addedPositionId > 0)
            {
                MessageBox.Show($"Position with ID {addedPositionId} has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Failed to add position.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            UpdatePositionList();
        }

        private void UpdatePositionList()
        {
            listBoxPositions.Items.Clear();
            listBoxPositions.Items.AddRange(_positionRep.GetAll().ToArray());

        }

        private void listBoxPositions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPositions.SelectedItem != null)
            {
                Position selectedPosition = (Position)listBoxPositions.SelectedItem;


                textBoxPosition.Text = selectedPosition.Name;
            }
        }

        private void buttonAddFootballTeam_Click(object sender, EventArgs e)
        {
            int coachId = Convert.ToInt32(comboBoxFootballTeamCoach.SelectedValue);

            if (comboBoxFootballTeamCoach.SelectedIndex == -1)
            {
                MessageBox.Show("Choose coach", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(textBoxFootballTeamFullName.Text))
            {
                MessageBox.Show("Enter team name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ctx = new FootballTeamContext();

            var coach = ctx.Coaches.First(x => x.Id == Convert.ToInt32(comboBoxFootballTeamCoach.SelectedValue));

            ctx.FootballTeams.Add(new FootballTeam
            {
                Coach = coach,
                FullName = textBoxFootballTeamFullName.Text,
                Country = textBoxFootballTeamCountry.Text,
                CreationDate = dateTimePickerFootballTeamCreationDate.Value,
            });

            ctx.SaveChanges();

            UpdateFootballTeamList();
        }

        private void UpdateFootballTeamList()
        {
            listBoxFootballTeams.Items.Clear();
            listBoxFootballTeams.Items.AddRange(_footballTeamRepos.GetAll().ToArray());
            comboBoxFootballTeamCoach.Items.Clear();

            var coachRep = new CoachRep();
            comboBoxFootballTeamCoach.DataSource = coachRep.GetAll().ToList();
            comboBoxFootballTeamCoach.DisplayMember = "FullName";
            comboBoxFootballTeamCoach.ValueMember = "Id";
        }

        private void listBoxFootballTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            FootballTeam selectedTeam = (FootballTeam)listBoxFootballTeams.SelectedItem;

            textBoxFootballTeamFullName.Text = selectedTeam.FullName;
            textBoxFootballTeamCountry.Text = selectedTeam.Country;
            dateTimePickerFootballTeamCreationDate.Value = selectedTeam.CreationDate;

            comboBoxFootballTeamCoach.SelectedValue = selectedTeam.Coach.Id;
        }

        private void buttonAddPlayerContract_Click(object sender, EventArgs e)
        {
            int playerId = Convert.ToInt32(comboBoxPlayerContractPlayer.SelectedValue);
            int footballTeamId = Convert.ToInt32(comboBoxPlayerContractFootballTeam.SelectedValue);

            if (comboBoxPlayerContractPlayer.SelectedIndex == -1)
            {
                MessageBox.Show("Choose coach", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxPlayerContractFootballTeam.SelectedIndex == -1)
            {
                MessageBox.Show("Choose football team", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ctx = new FootballTeamContext();

            var player = ctx.Players.First(x => x.Id == Convert.ToInt32(comboBoxPlayerContractPlayer.SelectedValue));
            var team = ctx.FootballTeams.First(x => x.Id == Convert.ToInt32(comboBoxPlayerContractFootballTeam.SelectedValue));

            DateTime startDate = dateTimePickerPlayerContractDateStart.Value;
            DateTime endDate = dateTimePickerPlayerContractDateEnd.Value;
            int salary = Convert.ToInt32(textBoxPlayerContractSalary.Text);

            ctx.PlayerContracts.Add(new PlayerContract
            {
                Player = player,
                Team = team,
                StartDate = startDate,
                EndDate = endDate,
                Salary = salary
            });

            ctx.SaveChanges();

            UpdatePlayerContractList();
        }

        private void UpdatePlayerContractList()
        {
            listBoxPlayersContracts.Items.Clear();
            listBoxPlayersContracts.Items.AddRange(_playerContractRepos.GetAll().ToArray());
        }

        private void listBoxPlayerContracts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPlayersContracts.SelectedItem != null)
            {
                PlayerContract selectedContract = (PlayerContract)listBoxPlayersContracts.SelectedItem;

                comboBoxPlayerContractPlayer.SelectedValue = selectedContract.Player.Id;
                comboBoxPlayerContractFootballTeam.SelectedValue = selectedContract.Team.Id;
                dateTimePickerPlayerContractDateStart.Value = selectedContract.StartDate;
                dateTimePickerPlayerContractDateEnd.Value = selectedContract.EndDate;
                textBoxPlayerContractSalary.Text = selectedContract.Salary.ToString();
            }
        }

        private void buttonRemoveCoach_Click(object sender, EventArgs e)
        {

            int idmem = 0;
            string line = listBoxCoaches.SelectedItem.ToString();
            Match match = Regex.Match(line, @"\d+");
            if (match.Success)
            {
                if (int.TryParse(match.Value, out int id))
                {
                    idmem = id;
                }
                else MessageBox.Show($"Error id {id}");
            }
            if (listBoxCoaches.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a coach to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var ctx = new FootballTeamContext())
            {

                _coachRepos.Delete(idmem);

            }

            UpdateCoachList();
        }

        private void buttonRemoveCoachContract_Click(object sender, EventArgs e)
        {
            int idmem = 0;
            string line = listBoxCoachesContracts.SelectedItem.ToString();
            Match match = Regex.Match(line, @"\d+");
            if (match.Success)
            {
                if (int.TryParse(match.Value, out int id))
                {
                    idmem = id;
                }
                else MessageBox.Show($"Error id {id}");
            }
            if (listBoxCoachesContracts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a coach contract to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var ctx = new FootballTeamContext())
            {

                _coachContractRepos.Delete(idmem);

            }

            UpdateCoachContractList();
        }

        private void buttonRemoveFootballTeam_Click(object sender, EventArgs e)
        {
            int idmem = 0;
            string line = listBoxFootballTeams.SelectedItem.ToString();
            Match match = Regex.Match(line, @"\d+");
            if (match.Success)
            {
                if (int.TryParse(match.Value, out int id))
                {
                    idmem = id;
                }
                else MessageBox.Show($"Error id {id}");
            }
            if (listBoxFootballTeams.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a football team to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var ctx = new FootballTeamContext())
            {

                _footballTeamRepos.Delete(idmem);

            }

            UpdateFootballTeamList();
        }

        private void buttonRemovePlayer_Click(object sender, EventArgs e)
        {
            int idmem = 0;
            string line = listBoxPlayers.SelectedItem.ToString();
            Match match = Regex.Match(line, @"\d+");
            if (match.Success)
            {
                if (int.TryParse(match.Value, out int id))
                {
                    idmem = id;
                }
                else MessageBox.Show($"Error id {id}");
            }
            if (listBoxPlayers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a player to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var ctx = new FootballTeamContext())
            {

                _playerRepos.Delete(idmem);

            }

            UpdatePlayerList();
        }

        private void buttonRemovePlayerContract_Click(object sender, EventArgs e)
        {
            int idmem = 0;
            string line = listBoxPlayersContracts.SelectedItem.ToString();
            Match match = Regex.Match(line, @"\d+");
            if (match.Success)
            {
                if (int.TryParse(match.Value, out int id))
                {
                    idmem = id;
                }
                else MessageBox.Show($"Error id {id}");
            }
            if (listBoxPlayersContracts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a player contract to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var ctx = new FootballTeamContext())
            {

                _playerContractRepos.Delete(idmem);

            }

            UpdatePlayerContractList();
        }

        private void buttonRemovePosition_Click(object sender, EventArgs e)
        {
            int idmem = 0;
            string line = listBoxPositions.SelectedItem.ToString();
            Match match = Regex.Match(line, @"\d+");
            if (match.Success)
            {
                if (int.TryParse(match.Value, out int id))
                {
                    idmem = id;
                }
                else MessageBox.Show($"Error id {id}");
            }
            if (listBoxPositions.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a position to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var ctx = new FootballTeamContext())
            {

                _positionRep.Delete(idmem);

            }

            UpdatePositionList();
        }

        private void listBoxPlayersTransfers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRemovePlayerTransfer_Click(object sender, EventArgs e)
        {
            int idmem = 0;
            string line = listBoxPlayersTransfers.SelectedItem.ToString();
            Match match = Regex.Match(line, @"\d+");
            if (match.Success)
            {
                if (int.TryParse(match.Value, out int id))
                {
                    idmem = id;
                }
                else MessageBox.Show($"Error id {id}");
            }
            if (listBoxPlayersTransfers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a player transfer to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var ctx = new FootballTeamContext())
            {

                _playerTransferRepos.Delete(idmem);

            }

            UpdatePlayerTransfer();
        }

        private void UpdatePlayerTransfer()
        {
            listBoxPlayersTransfers.Items.Clear();
            listBoxPlayersTransfers.Items.AddRange(_playerContractRepos.GetAll().ToArray());
        }

        private void buttonFindCoach_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxFindCoach.Text.ToLower();

            listBoxCoaches.Items.Clear();

            var ctx = new FootballTeamContext();
            foreach (var coach in ctx.Coaches)
            {
                if (coach.FullName.ToLower().Contains(searchTerm))
                {

                    listBoxCoaches.Items.Add(coach.ToString());
                }
            }
        }

        private void buttonCancelCoach_Click(object sender, EventArgs e)
        {
            UpdateCoachList();
        }

        private void buttonFindCoachContract_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBoxFindCoachContract.Text, out int coachContractId))
            {

                var coachContract = Get(coachContractId);

                if (coachContract != null)
                {

                    string contractDetails = $"ID: {coachContract.Id}\n" +
                                             $"Start date: {coachContract.StartDate}\n" +
                                             $"End date: {coachContract.EndDate}\n" +
                                             $"Salary: {coachContract.Salary}";

                    MessageBox.Show(contractDetails, $"Контракт тренера з ID {coachContractId} знайдено.");
                }
                else
                {
                    MessageBox.Show($"Контракт тренера з ID {coachContractId} не знайдено.");
                }
            }
            else
            {
                MessageBox.Show("Недійсний ID контракту тренера. Будь ласка, введіть дійсне числове значення.");
            }
        }


        public CoachContract Get(int id)
        {
            using (var ctx = new FootballTeamContext())
            {
                return ctx.CoachContracts.Find(id);
            }
        }

        private void buttonFindFootballTeam_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxFindFootballTeam.Text.ToLower();


            listBoxFootballTeams.Items.Clear();

            var ctx = new FootballTeamContext();

            foreach (var footballTeam in ctx.FootballTeams)
            {
                if (footballTeam.FullName.ToLower().Contains(searchTerm))
                {

                    listBoxFootballTeams.Items.Add(
                    $" ID: {footballTeam.Id}," +
                    $" Full name: {footballTeam.FullName}," +
                    $" Creation date: {footballTeam.CreationDate.ToString("yyyy-MM-dd")}," +
                    $" Country team: {footballTeam.Country}," +
                    $" Coach name: {footballTeam.Coach?.Name() ?? "No Coach"}"
                    );
                }
            }


        }
        private void buttonCancelFootballTeam_Click(object sender, EventArgs e)
        {
            UpdateFootballTeamList();
        }
        private Coach GetSelectedCoach()
        {

            if (listBoxCoaches.SelectedItem != null)
            {
                return (Coach)listBoxCoaches.SelectedItem;
            }

            return null;
        }

        private void buttonEditCoach_Click(object sender, EventArgs e)
        {

            Coach selectedCoach = GetSelectedCoach();
            var ctx = new FootballTeamContext();
            ctx.Coaches.Remove(ctx.Coaches.Find(selectedCoach.Id));

            if (selectedCoach != null)
            {
                string updatedFullName = textBoxCoachFullName.Text;
                int updatedAge = Convert.ToInt32(textBoxCoachAge.Text);
                int updatedCurrentMatches = Convert.ToInt32(textBoxCoachCurrentMatches.Text);
                int updatedWonTrophies = Convert.ToInt32(textBoxCoachWonTrofies.Text);
                int updatedWonMatches = Convert.ToInt32(textBoxWonMatches.Text);
                int updatedDrawnMatches = Convert.ToInt32(textBoxDrawnMatches.Text);
                int updatedLoosedMatches = Convert.ToInt32(textBoxLoosedMatches.Text);

                Coach updatedCoach = new Coach
                {

                    FullName = updatedFullName,
                    Age = updatedAge,
                    CurrentMatchesAmount = updatedCurrentMatches,
                    WonTrofies = updatedWonTrophies,
                    WonMatches = updatedWonMatches,
                    DrawnMatches = updatedDrawnMatches,
                    LoosedMatches = updatedLoosedMatches
                };


                ctx.Update(updatedCoach);
                ctx.SaveChanges();
                UpdateCoachList();
            }
        }

        private Player GetSelectedPlayer()
        {

            if (listBoxPlayers.SelectedItem != null && listBoxPlayers.SelectedItem is Player)
            {
                return (Player)listBoxPlayers.SelectedItem;
            }

            return null;
        }

        private void buttonEditPlayer_Click(object sender, EventArgs e)
        {
            Player selectedPlayer = GetSelectedPlayer();

            if (selectedPlayer != null)
            {
                var ctx = new FootballTeamContext();
                Player updatedPlayer = ctx.Players.Find(selectedPlayer.Id);

                updatedPlayer.Age = int.Parse(textBoxPlayerAge.Text);
                updatedPlayer.FullName = textBoxPlayerFullName.Text;
                updatedPlayer.IsCaptain = checkBoxPlayerIsCaptain.Checked;
                updatedPlayer.WorkingLeg = textBoxPlayerWorkingLeg.Text;
                updatedPlayer.Goals = int.Parse(textBoxPlayerGoals.Text);
                updatedPlayer.Assists = int.Parse(textBoxAssists.Text);

                ctx.SaveChanges();
                UpdatePlayerList();
            }
        }

    }
}
