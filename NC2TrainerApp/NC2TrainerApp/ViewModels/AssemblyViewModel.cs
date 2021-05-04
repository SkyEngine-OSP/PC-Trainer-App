namespace NC2TrainerApp.ViewModels
{
     public class AssemblyViewModel : BaseVM
     {
          public double ScreenWidth => Xamarin.Forms.Application.Current.MainPage.Width;

          #region Case
          bool caseIsVisible;
          public bool CaseIsVisible
          {
               get => caseIsVisible;
               set => SetProperty(ref caseIsVisible, value);
          }

          public string CaseImgSource { get; }
          public string CaseLabel { get; }
          #endregion

          #region CaseCover
          bool caseCoverIsVisible;
          public bool CaseCoverIsVisible
          {
               get => caseCoverIsVisible;
               set => SetProperty(ref caseCoverIsVisible, value);
          }

          public string CaseCoverImgSource { get; }
          public string CaseCoverLabel { get; }
          #endregion

          #region CaseCoverScrew
          bool caseCoverScrewIsVisible;
          public bool CaseCoverScrewIsVisible
          {
               get => caseCoverScrewIsVisible;
               set => SetProperty(ref caseCoverScrewIsVisible, value);
          }

          public string CaseCoverScrewImgSource { get; }
          public string CaseCoverScrewLabel { get; }
          #endregion

          #region HardDiskDrive
          bool hardDiskDriveIsVisible;
          public bool HardDiskDriveIsVisible
          {
               get => hardDiskDriveIsVisible;
               set => SetProperty(ref hardDiskDriveIsVisible, value);
          }

          public string HardDiskDriveImgSource { get; }
          public string HardDiskDriveLabel { get; }
          #endregion

          #region HeatSink
          bool heatSinkIsVisible;
          public bool HeatSinkIsVisible
          {
               get => heatSinkIsVisible;
               set => SetProperty(ref heatSinkIsVisible, value);
          }

          public string HeatSinkImgSource { get; }
          public string HeatSinkLabel { get; }
          #endregion

          #region MemoryModule
          bool memoryModuleIsVisible;
          public bool MemoryModuleIsVisible
          {
               get => memoryModuleIsVisible;
               set => SetProperty(ref memoryModuleIsVisible, value);
          }

          public string MemoryModuleImgSource { get; }
          public string MemoryModuleLabel { get; }
          #endregion

          #region Motherboard
          bool motherboardIsVisible;
          public bool MotherboardIsVisible
          {
               get => motherboardIsVisible;
               set => SetProperty(ref motherboardIsVisible, value);
          }

          public string MotherboardImgSource { get; }
          public string MotherboardLabel { get; }
          #endregion

          #region MotherboardScrew
          bool motherboardScrewIsVisible;
          public bool MotherboardScrewIsVisible
          {
               get => motherboardScrewIsVisible;
               set => SetProperty(ref motherboardScrewIsVisible, value);
          }

          public string MotherboardScrewImgSource { get; }
          public string MotherboardScrewLabel { get; }
          #endregion

          #region PowerSupply
          bool powerSupplyIsVisible;
          public bool PowerSupplyIsVisible
          {
               get => powerSupplyIsVisible;
               set => SetProperty(ref powerSupplyIsVisible, value);
          }

          public string PowerSupplyImgSource { get; }
          public string PowerSupplyLabel { get; }
          #endregion

          #region Processor
          bool processorIsVisible;
          public bool ProcessorIsVisible
          {
               get => processorIsVisible;
               set => SetProperty(ref processorIsVisible, value);
          }

          public string ProcessorImgSource { get; }
          public string ProcessorLabel { get; }
          #endregion


          public AssemblyViewModel()
          {
               CaseIsVisible = true;
               CaseImgSource = "img_assembly_case.png";
               CaseLabel = "Case";

               CaseCoverIsVisible = true;
               CaseCoverImgSource = "img_assembly_case_cover.png";
               CaseCoverLabel = "Case Cover";

               CaseCoverScrewIsVisible = true;
               CaseCoverScrewImgSource = "img_assembly_case_cover_screw.png";
               CaseCoverScrewLabel = "Case Cover Screw";

               HardDiskDriveIsVisible = true;
               HardDiskDriveImgSource = "img_assembly_hard_disk_drive.png";
               HardDiskDriveLabel = "Hard Disk Drive";

               HeatSinkIsVisible = true;
               HeatSinkImgSource = "img_assembly_heat_sink.png";
               HeatSinkLabel = "Heatsink";

               MemoryModuleIsVisible = true;
               MemoryModuleImgSource = "img_assembly_memory_module.png";
               MemoryModuleLabel = "Memory Module";

               MotherboardIsVisible = true;
               MotherboardImgSource = "img_assembly_motherboard.png";
               MotherboardLabel = "Motherboard";

               MotherboardScrewIsVisible = true;
               MotherboardScrewImgSource = "img_assembly_motherboard_screw.png";
               MotherboardScrewLabel = "Motherboard Screw";

               PowerSupplyIsVisible = true;
               PowerSupplyImgSource = "img_assembly_power_supply.png";
               PowerSupplyLabel = "Power Supply";

               ProcessorIsVisible = true;
               ProcessorImgSource = "img_assembly_processor.png";
               ProcessorLabel = "Processor";
          }
     }
}