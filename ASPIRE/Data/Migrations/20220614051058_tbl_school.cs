﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPIRE.Data.Migrations
{
    public partial class tbl_school : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "School",
                schema: "master",
                columns: table => new
                {
                    SchoolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BEMISCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shift = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFunctional = table.Column<bool>(type: "bit", nullable: false),
                    PakkaRoom = table.Column<int>(type: "int", nullable: false),
                    KachaRoom = table.Column<int>(type: "int", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tehsil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTehsil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardNo = table.Column<int>(type: "int", nullable: false),
                    VillageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClusterBemisCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClusterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClusterDDOCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClusterFeedingSchoolsPrimary = table.Column<int>(type: "int", nullable: false),
                    ClusterFeedingSchoolsMiddle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearofNonFunctinal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonOfNonFunctional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDisableStudentsInSchool = table.Column<bool>(type: "bit", nullable: false),
                    IsRampforStudentsOrTeachers = table.Column<bool>(type: "bit", nullable: false),
                    IsBuilding = table.Column<bool>(type: "bit", nullable: false),
                    SchoolOwnedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingStructure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSpaceForNewRooms = table.Column<bool>(type: "bit", nullable: false),
                    NoOfRoomsWithWindowsAndVantilation = table.Column<int>(type: "int", nullable: false),
                    IsProperSeverageSystem = table.Column<bool>(type: "bit", nullable: false),
                    IsWaterFacilityInToilets = table.Column<bool>(type: "bit", nullable: false),
                    IsBoundaryWall = table.Column<bool>(type: "bit", nullable: false),
                    BoundaryWallStructure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoundaryWallCondition = table.Column<bool>(type: "bit", nullable: false),
                    IsPlayGround = table.Column<bool>(type: "bit", nullable: false),
                    IsElectricityInArea = table.Column<bool>(type: "bit", nullable: false),
                    IsElectricity = table.Column<bool>(type: "bit", nullable: false),
                    ElectricitySource = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistanceOfNearestPoll = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsGasInArea = table.Column<bool>(type: "bit", nullable: false),
                    IsGasInSchool = table.Column<bool>(type: "bit", nullable: false),
                    IsGovtDrinkingWaterScheme = table.Column<bool>(type: "bit", nullable: false),
                    IsDrinkingWaterAtSchool = table.Column<bool>(type: "bit", nullable: false),
                    SourceOfWater = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsWaterTank = table.Column<bool>(type: "bit", nullable: false),
                    DistanceOfNearestWaterSource = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsTelephoneAvailabe = table.Column<bool>(type: "bit", nullable: false),
                    IsFunctionStatusTelephone = table.Column<bool>(type: "bit", nullable: false),
                    ClosedReasonTelephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsInternetAvailabe = table.Column<bool>(type: "bit", nullable: false),
                    IsFunctionStatusInternet = table.Column<bool>(type: "bit", nullable: false),
                    ClosedReasonInternet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsScienceLab = table.Column<bool>(type: "bit", nullable: false),
                    IsFunctionStatusScienceLab = table.Column<bool>(type: "bit", nullable: false),
                    IsComputerLab = table.Column<bool>(type: "bit", nullable: false),
                    IsLibraryAvailable = table.Column<bool>(type: "bit", nullable: false),
                    CleaningResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsWashbasinAvailable = table.Column<bool>(type: "bit", nullable: false),
                    IsWaterforWashBasin = table.Column<bool>(type: "bit", nullable: false),
                    IsSoapForWashBasin = table.Column<bool>(type: "bit", nullable: false),
                    CleaningCycleOfWashBasin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsTeacherUsesTeachingMeterialOnHealth = table.Column<bool>(type: "bit", nullable: false),
                    MajorDiseaseCauseForAbsentism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFirstaidKit = table.Column<bool>(type: "bit", nullable: false),
                    IsTrainingOnFirstAidKit = table.Column<bool>(type: "bit", nullable: false),
                    IsInspectionOfCleaning = table.Column<bool>(type: "bit", nullable: false),
                    IsSeprateRoomForECE = table.Column<bool>(type: "bit", nullable: false),
                    IsFullTimeTeacherForECE = table.Column<bool>(type: "bit", nullable: false),
                    IsTrendExtraCracularActivity = table.Column<bool>(type: "bit", nullable: false),
                    Activity1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAudioAndVideoEquipment = table.Column<bool>(type: "bit", nullable: false),
                    IsTeacherUsesAudioAndVideoEquipment = table.Column<bool>(type: "bit", nullable: false),
                    IsTrainingOnMHMKits = table.Column<bool>(type: "bit", nullable: false),
                    IsMHMKitsAtSchool = table.Column<bool>(type: "bit", nullable: false),
                    IsPTSMC = table.Column<bool>(type: "bit", nullable: false),
                    IsPTSMCParticipatedInAnyActivityCurrentYear = table.Column<bool>(type: "bit", nullable: false),
                    IsMeetingRecordesAvailable = table.Column<bool>(type: "bit", nullable: false),
                    IsChildOfPTSMCMembersAreEnrolled = table.Column<bool>(type: "bit", nullable: false),
                    IsAnySDPFormPTSMCLast3Years = table.Column<bool>(type: "bit", nullable: false),
                    IsExaminationHall = table.Column<bool>(type: "bit", nullable: false),
                    NumberOfVisitByEducationalManager = table.Column<int>(type: "int", nullable: false),
                    KachiBoys = table.Column<int>(type: "int", nullable: false),
                    KachiGirls = table.Column<int>(type: "int", nullable: false),
                    PakiBoys = table.Column<int>(type: "int", nullable: false),
                    PakiGirls = table.Column<int>(type: "int", nullable: false),
                    TwoBoys = table.Column<int>(type: "int", nullable: false),
                    TwoGirls = table.Column<int>(type: "int", nullable: false),
                    ThreeBoys = table.Column<int>(type: "int", nullable: false),
                    ThreeGirls = table.Column<int>(type: "int", nullable: false),
                    FourBoys = table.Column<int>(type: "int", nullable: false),
                    FourGirls = table.Column<int>(type: "int", nullable: false),
                    FiveBoys = table.Column<int>(type: "int", nullable: false),
                    FiveGirls = table.Column<int>(type: "int", nullable: false),
                    SixBoys = table.Column<int>(type: "int", nullable: false),
                    SixGirls = table.Column<int>(type: "int", nullable: false),
                    SevenBoys = table.Column<int>(type: "int", nullable: false),
                    SevenGilrs = table.Column<int>(type: "int", nullable: false),
                    EightBoys = table.Column<int>(type: "int", nullable: false),
                    EightGilrs = table.Column<int>(type: "int", nullable: false),
                    NineBoys = table.Column<int>(type: "int", nullable: false),
                    NineGirls = table.Column<int>(type: "int", nullable: false),
                    TenBoys = table.Column<int>(type: "int", nullable: false),
                    TenGirls = table.Column<int>(type: "int", nullable: false),
                    ElevenBoys = table.Column<int>(type: "int", nullable: false),
                    ElevenGirls = table.Column<int>(type: "int", nullable: false),
                    TwelveBoys = table.Column<int>(type: "int", nullable: false),
                    TwelveGilrs = table.Column<int>(type: "int", nullable: false),
                    TotalSchoolProfileStudent = table.Column<int>(type: "int", nullable: false),
                    TotalStudentProfileEntered = table.Column<int>(type: "int", nullable: false),
                    ContactPersonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSolarization = table.Column<bool>(type: "bit", nullable: false),
                    IsITLab = table.Column<bool>(type: "bit", nullable: false),
                    IsInternetConnectivity = table.Column<bool>(type: "bit", nullable: false),
                    IsScienceLabEquipment = table.Column<bool>(type: "bit", nullable: false),
                    IsHygieneKit = table.Column<bool>(type: "bit", nullable: false),
                    IsLearningKit = table.Column<bool>(type: "bit", nullable: false),
                    IsMHMKit = table.Column<bool>(type: "bit", nullable: false),
                    IsdistanceLearningKit = table.Column<bool>(type: "bit", nullable: false),
                    SencTeaching = table.Column<int>(type: "int", nullable: false),
                    AppTeaching = table.Column<int>(type: "int", nullable: false),
                    TeachingMale = table.Column<int>(type: "int", nullable: false),
                    TeachingFemale = table.Column<int>(type: "int", nullable: false),
                    TotalTeachingStaff = table.Column<int>(type: "int", nullable: false),
                    SencNonTeaching = table.Column<int>(type: "int", nullable: false),
                    AppNonTeaching = table.Column<int>(type: "int", nullable: false),
                    NonteachingMale = table.Column<int>(type: "int", nullable: false),
                    NonteachingFemale = table.Column<int>(type: "int", nullable: false),
                    TotalNonTeachingStaff = table.Column<int>(type: "int", nullable: false),
                    VchCreatedBy = table.Column<int>(type: "int", nullable: false),
                    DtmCreatedDate = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    UnionCouncilId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.SchoolId);
                    table.ForeignKey(
                        name: "FK_School_UnionCouncil_UnionCouncilId",
                        column: x => x.UnionCouncilId,
                        principalSchema: "master",
                        principalTable: "UnionCouncil",
                        principalColumn: "UnionCouncilId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_School_UnionCouncilId",
                schema: "master",
                table: "School",
                column: "UnionCouncilId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "School",
                schema: "master");
        }
    }
}
