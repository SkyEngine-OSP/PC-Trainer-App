using NC2TrainerApp.Helpers;
using NC2TrainerApp.ViewModels;
using System;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NC2TrainerApp.Views
{
     [XamlCompilation(XamlCompilationOptions.Compile)]
     public partial class AssemblyPage : ContentPage
     {
          string caseSource;


          public AssemblyPage()
          {
               InitializeComponent();
          }


          private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
          {
               Application.Current.MainPage.DisplayAlert("", $"{imgCaseDropZone.Source ?? string.Empty}", "OK");
          }

          int dragCount = 0;
          private void CaseDropZone_PropertyChanged(object sender, PropertyChangedEventArgs e)
          {
               if (e.PropertyName == "Source")
               {
                    caseSource = imgCaseDropZone.Source.ToString().Split(':').Last().Trim();

                    if (string.IsNullOrEmpty(caseSource))
                    {
                         return;
                    }

                    var ctx = (BindingContext as AssemblyViewModel);

                    if (caseSource == "img_assembly_case.png")
                    {
                         ctx.CaseIsVisible = false;

                         imgMotherboardDropZone.IsVisible = true;
                    }
                    else
                    {
                         imgCaseDropZone.Source = string.Empty;

                         Global.Score.PCAssembly -= 5;

                         DisplayAlert($"Score: {Global.Score.PCAssembly}", "The pre-requisite component for this part has not yet been placed.", "OK");

                         //lblDirections.Text = $"Drag Count: {++dragCount}";
                    }
               }
          }

          private void MotherboardDropZone_PropertyChanged(object sender, PropertyChangedEventArgs e)
          {
               if (e.PropertyName == "Source")
               {
                    caseSource = imgMotherboardDropZone.Source.ToString().Split(':').Last().Trim();

                    if (string.IsNullOrEmpty(caseSource))
                    {
                         return;
                    }

                    var ctx = (BindingContext as AssemblyViewModel);

                    if (caseSource == "img_assembly_motherboard.png")
                    {
                         ctx.MotherboardIsVisible = false;

                         imgMotherboardScrewDropZone.IsVisible = true;
                    }
                    else
                    {
                         imgMotherboardDropZone.Source = string.Empty;

                         Global.Score.PCAssembly -= 5;

                         DisplayAlert($"Score: {Global.Score.PCAssembly}", "The pre-requisite component for this part has not yet been placed.", "OK");

                         //lblDirections.Text = $"Drag Count: {++dragCount}";
                    }
               }
          }

          private void MotherboardScrewDropZone_PropertyChanged(object sender, PropertyChangedEventArgs e)
          {
               if (e.PropertyName == "Source")
               {
                    caseSource = imgMotherboardScrewDropZone.Source.ToString().Split(':').Last().Trim();

                    if (string.IsNullOrEmpty(caseSource))
                    {
                         return;
                    }

                    var ctx = (BindingContext as AssemblyViewModel);

                    if (caseSource == "img_assembly_motherboard_screw.png")
                    {
                         ctx.MotherboardScrewIsVisible = false;

                         imgProcessorDropZone.IsVisible = true;
                    }
                    else
                    {
                         imgMotherboardScrewDropZone.Source = string.Empty;

                         Global.Score.PCAssembly -= 5;

                         DisplayAlert($"Score: {Global.Score.PCAssembly}", "The pre-requisite component for this part has not yet been placed.", "OK");

                         //lblDirections.Text = $"Drag Count: {++dragCount}";
                    }
               }
          }

          private void ProcessorDropZone_PropertyChanged(object sender, PropertyChangedEventArgs e)
          {
               if (e.PropertyName == "Source")
               {
                    caseSource = imgProcessorDropZone.Source.ToString().Split(':').Last().Trim();

                    if (string.IsNullOrEmpty(caseSource))
                    {
                         return;
                    }

                    var ctx = (BindingContext as AssemblyViewModel);

                    if (caseSource == "img_assembly_processor.png")
                    {
                         ctx.ProcessorIsVisible = false;

                         imgHeatSinkDropZone.IsVisible = true;
                    }
                    else
                    {
                         imgProcessorDropZone.Source = string.Empty;

                         Global.Score.PCAssembly -= 5;

                         DisplayAlert($"Score: {Global.Score.PCAssembly}", "The pre-requisite component for this part has not yet been placed.", "OK");

                         //lblDirections.Text = $"Drag Count: {++dragCount}";
                    }
               }
          }

          private void HeatSinkDropZone_PropertyChanged(object sender, PropertyChangedEventArgs e)
          {
               if (e.PropertyName == "Source")
               {
                    caseSource = imgHeatSinkDropZone.Source.ToString().Split(':').Last().Trim();

                    if (string.IsNullOrEmpty(caseSource))
                    {
                         return;
                    }

                    var ctx = (BindingContext as AssemblyViewModel);

                    if (caseSource == "img_assembly_heat_sink.png")
                    {
                         ctx.HeatSinkIsVisible = false;

                         imgMemoryModuleDropZone.IsVisible = true;
                    }
                    else
                    {
                         imgHeatSinkDropZone.Source = string.Empty;

                         Global.Score.PCAssembly -= 5;

                         DisplayAlert($"Score: {Global.Score.PCAssembly}", "The pre-requisite component for this part has not yet been placed.", "OK");

                         //lblDirections.Text = $"Drag Count: {++dragCount}";
                    }
               }
          }

          private void MemoryModuleDropZone_PropertyChanged(object sender, PropertyChangedEventArgs e)
          {
               if (e.PropertyName == "Source")
               {
                    caseSource = imgMemoryModuleDropZone.Source.ToString().Split(':').Last().Trim();

                    if (string.IsNullOrEmpty(caseSource))
                    {
                         return;
                    }

                    var ctx = (BindingContext as AssemblyViewModel);

                    if (caseSource == "img_assembly_memory_module.png")
                    {
                         ctx.MemoryModuleIsVisible = false;

                         imgHardDiskDriveDropZone.IsVisible = true;
                    }
                    else
                    {
                         imgMemoryModuleDropZone.Source = string.Empty;

                         Global.Score.PCAssembly -= 5;

                         DisplayAlert($"Score: {Global.Score.PCAssembly}", "The pre-requisite component for this part has not yet been placed.", "OK");

                         //lblDirections.Text = $"Drag Count: {++dragCount}";
                    }
               }
          }

          private void HardDiskDriveDropZone_PropertyChanged(object sender, PropertyChangedEventArgs e)
          {
               if (e.PropertyName == "Source")
               {
                    caseSource = imgHardDiskDriveDropZone.Source.ToString().Split(':').Last().Trim();

                    if (string.IsNullOrEmpty(caseSource))
                    {
                         return;
                    }

                    var ctx = (BindingContext as AssemblyViewModel);

                    if (caseSource == "img_assembly_hard_disk_drive.png")
                    {
                         ctx.HardDiskDriveIsVisible = false;

                         imgPowerSupplyDropZone.IsVisible = true;
                    }
                    else
                    {
                         imgHardDiskDriveDropZone.Source = string.Empty;

                         Global.Score.PCAssembly -= 5;

                         DisplayAlert($"Score: {Global.Score.PCAssembly}", "The pre-requisite component for this part has not yet been placed.", "OK");

                         //lblDirections.Text = $"Drag Count: {++dragCount}";
                    }
               }
          }

          private void PowerSupplyDropZone_PropertyChanged(object sender, PropertyChangedEventArgs e)
          {
               if (e.PropertyName == "Source")
               {
                    caseSource = imgPowerSupplyDropZone.Source.ToString().Split(':').Last().Trim();

                    if (string.IsNullOrEmpty(caseSource))
                    {
                         return;
                    }

                    var ctx = (BindingContext as AssemblyViewModel);

                    if (caseSource == "img_assembly_power_supply.png")
                    {
                         ctx.PowerSupplyIsVisible = false;

                         imgCaseCoverDropZone.IsVisible = true;
                    }
                    else
                    {
                         imgPowerSupplyDropZone.Source = string.Empty;

                         Global.Score.PCAssembly -= 5;

                         DisplayAlert($"Score: {Global.Score.PCAssembly}", "The pre-requisite component for this part has not yet been placed.", "OK");

                         //lblDirections.Text = $"Drag Count: {++dragCount}";
                    }
               }
          }

          private void CaseCoverDropZone_PropertyChanged(object sender, PropertyChangedEventArgs e)
          {
               if (e.PropertyName == "Source")
               {
                    caseSource = imgCaseCoverDropZone.Source.ToString().Split(':').Last().Trim();

                    if (string.IsNullOrEmpty(caseSource))
                    {
                         return;
                    }

                    var ctx = (BindingContext as AssemblyViewModel);

                    if (caseSource == "img_assembly_case_cover.png")
                    {
                         ctx.CaseCoverIsVisible = false;

                         imgCaseCoverScrewDropZone.IsVisible = true;
                    }
                    else
                    {
                         imgCaseCoverDropZone.Source = string.Empty;

                         Global.Score.PCAssembly -= 5;

                         DisplayAlert($"Score: {Global.Score.PCAssembly}", "The pre-requisite component for this part has not yet been placed.", "OK");

                         //lblDirections.Text = $"Drag Count: {++dragCount}";
                    }
               }
          }

          private async void CaseCoverScrewDropZone_PropertyChanged(object sender, PropertyChangedEventArgs e)
          {
               if (e.PropertyName == "Source")
               {
                    caseSource = imgCaseCoverScrewDropZone.Source.ToString().Split(':').Last().Trim();

                    if (string.IsNullOrEmpty(caseSource))
                    {
                         return;
                    }

                    var ctx = (BindingContext as AssemblyViewModel);

                    if (caseSource == "img_assembly_case_cover_screw.png")
                    {
                         ctx.CaseCoverScrewIsVisible = false;

                         await DisplayAlert("PC Assembly Completed (1/2)", $"Congratulations on successfully building a Desktop Computer.\r\n\r\nYour final score is: {Global.Score.PCAssembly}.", "OK");
                    }
                    else
                    {
                         imgCaseCoverScrewDropZone.Source = string.Empty;

                         Global.Score.PCAssembly -= 5;

                         await DisplayAlert($"Score: {Global.Score.PCAssembly}", "The pre-requisite component for this part has not yet been placed.", "OK");
                    }
               }
          }
     }
}