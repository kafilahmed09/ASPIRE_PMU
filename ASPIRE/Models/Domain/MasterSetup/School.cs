using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPIRE.Models.Domain.MasterSetup
{
    [Table("School", Schema = "master")]
    public class School
    {
        [Key]
        public int SchoolId { get; set; }
        #region --- School Basic Information ----
        public string BEMISCode { get; set; }
        public string SchoolName { get; set; }
        public string SchoolLevel { get; set; }        
        public string Gender { get; set; }
        public string Shift { get; set; }
        public bool IsFunctional { get; set; }
        public int PakkaRoom { get; set; }
        public int KachaRoom { get; set; }
        public string District { get; set; }
        public string Tehsil { get; set; }
        public string SubTehsil { get; set; }
        public string UC { get; set; }
        public string WardName { get; set; }
        public int WardNo { get; set; }
        public string VillageName { get; set; }
        public string NA { get; set; }
        public string PA { get; set; }
        public string ClusterBemisCode { get; set; }
        public string ClusterName { get; set; }
        public string ClusterDDOCode { get; set; }
        public string SchoolContactNo { get; set; }
        public int ClusterFeedingSchoolsPrimary { get; set; }
        public string ClusterFeedingSchoolsMiddle { get; set; }
        public string Location { get; set; }
        public string Zone { get; set; }
        public string YearofNonFunctinal { get; set; }
        public string ReasonOfNonFunctional { get; set; }
        public bool IsDisableStudentsInSchool { get; set; }
        public bool IsRampforStudentsOrTeachers { get; set; }
        public bool IsBuilding { get; set; }
        public string SchoolOwnedBy { get; set; }
        public string BuildingStructure { get; set; }
        public string BuildingCondition { get; set; }
        public bool IsSpaceForNewRooms { get; set; }
        #endregion
        public int NoOfRoomsWithWindowsAndVantilation { get; set; }
        public bool IsProperSeverageSystem { get; set; }
        public bool IsWaterFacilityInToilets { get; set; }
        public bool IsBoundaryWall { get; set; }
        public string BoundaryWallStructure { get; set; }
        public string BoundaryWallCondition { get; set; }
        public bool IsPlayGround { get; set; }
        public bool IsElectricityInArea { get; set; }
        public bool IsElectricity { get; set; }
        public string ElectricitySource { get; set; }
        public string DistanceOfNearestPoll { get; set; }
        public bool IsGasInArea { get; set; }
        public bool IsGasInSchool { get; set; }
        public bool IsGovtDrinkingWaterScheme { get; set; }
        public bool IsDrinkingWaterAtSchool { get; set; }
        public string SourceOfWater { get; set; }
        public bool IsWaterTank { get; set; }
        public string DistanceOfNearestWaterSource { get; set; }
        public bool IsTelephoneAvailabe { get; set; }
        public bool IsFunctionStatusTelephone { get; set; }
        public string ClosedReasonTelephone { get; set; }
        public bool IsInternetAvailabe { get; set; }
        public bool IsFunctionStatusInternet { get; set; }
        public string ClosedReasonInternet { get; set; }
        public bool IsScienceLab { get; set; }
        public bool IsFunctionStatusScienceLab { get; set; }
        public bool IsComputerLab { get; set; }
        public bool IsLibraryAvailable { get; set; }
        public string CleaningResponsibility { get; set; }
        public bool IsWashbasinAvailable { get; set; }
        public bool IsWaterforWashBasin { get; set; }
        public bool IsSoapForWashBasin { get; set; }
        public string CleaningCycleOfWashBasin { get; set; }
        public bool IsTeacherUsesTeachingMeterialOnHealth { get; set; }
        public string MajorDiseaseCauseForAbsentism { get; set; }
        public bool IsFirstaidKit { get; set; }
        public bool IsTrainingOnFirstAidKit { get; set; }
        public bool IsInspectionOfCleaning { get; set; }
        public bool IsSeprateRoomForECE { get; set; }
        public bool IsFullTimeTeacherForECE { get; set; }
        public bool IsTrendExtraCracularActivity { get; set; }
        public string Activity1 { get; set; }
        public bool IsAudioAndVideoEquipment { get; set; }
        public bool IsTeacherUsesAudioAndVideoEquipment { get; set; }
        public bool IsTrainingOnMHMKits { get; set; }
        public bool IsMHMKitsAtSchool { get; set; }
        public bool IsPTSMC { get; set; }
        public bool IsPTSMCParticipatedInAnyActivityCurrentYear { get; set; }
        public bool IsMeetingRecordesAvailable { get; set; }
        public bool IsChildOfPTSMCMembersAreEnrolled { get; set; }
        public bool IsAnySDPFormPTSMCLast3Years { get; set; }
        public bool IsExaminationHall { get; set; }
        public int NumberOfVisitByEducationalManager { get; set; }
        #region ---------------------Enrollment---------------------------
        public int KachiBoys { get; set; }
        public int KachiGirls { get; set; }
        public int PakiBoys { get; set; }
        public int PakiGirls { get; set; }
        public int TwoBoys { get; set; }
        public int TwoGirls { get; set; }
        public int ThreeBoys { get; set; }
        public int ThreeGirls { get; set; }
        public int FourBoys { get; set; }
        public int FourGirls { get; set; }
        public int FiveBoys { get; set; }
        public int FiveGirls { get; set; }
        public int SixBoys { get; set; }
        public int SixGirls { get; set; }
        public int SevenBoys { get; set; }
        public int SevenGilrs { get; set; }
        public int EightBoys { get; set; }
        public int EightGilrs { get; set; }
        public int NineBoys { get; set; }
        public int NineGirls { get; set; }
        public int TenBoys { get; set; }
        public int TenGirls { get; set; }
        public int ElevenBoys { get; set; }
        public int ElevenGirls { get; set; }
        public int TwelveBoys { get; set; }
        public int TwelveGilrs { get; set; }
        public int TotalSchoolProfileStudent { get; set; }
        public int TotalStudentProfileEntered { get; set; }
        #endregion

        #region ------------- Interventions -----------------
        public string ContactPersonName { get; set; }
        public string ContactNumber { get; set; }
        public bool IsSolarization { get; set; }
        public bool IsITLab { get; set; }
        public bool ChildrenReceivingDistanceLearningKits  { get; set; }
        public bool IsInternetConnectivity { get; set; }
        public bool IsScienceLabEquipment { get; set; }
        public bool IsHygieneKit { get; set; }
        public bool IsLearningKit { get; set; }
        public bool IsMHMKit { get; set; }        
        #endregion

        #region --- Teacher Information ------
        public int SencTeaching { get; set; }
        public int AppTeaching { get; set; }
        public int TeachingMale { get; set; }
        public int TeachingFemale { get; set; }
        public int TotalTeachingStaff { get; set; }
        public int SencNonTeaching { get; set; }
        public int AppNonTeaching { get; set; }
        public int NonteachingMale { get; set; }
        public int NonteachingFemale { get; set; }
        public int TotalNonTeachingStaff { get; set; }
        public string VchCreatedBy { get; set; }
        public DateTime DtmCreatedDate { get; set; }
        public int Total { get; set; }
        public int KachaHMR { get; set; }
        public int PakkaHMR { get; set; }
        public int KachaClerkOffice { get; set; }
        public int PakkaClerkOffice { get; set; }
        public int KachaHall { get; set; }
        public int PakkaHall { get; set; }
        public int KachaStaffRoom { get; set; }
        public int PakkaStaffRoom { get; set; }
        public int KachaGuardRoom    { get; set; }
        public int PakkaGuardRoom { get; set; }
        public int KachaToilet { get; set; }
        public int KachaSportsRoom  { get; set; }
        public int PakkaToilet { get; set; }
        public int PakkaSportsRoom { get; set; }
        public int KachaResourceCenter { get; set; }
        public int PakkaResourceCenter { get; set; }
        #endregion
        [ForeignKey("UnionCouncil")]
        [Display(Name = "Union Council")]
        public int UnionCouncilId { get; set; }
        public virtual UnionCouncil UnionCouncil { get; set; }
    }
}
