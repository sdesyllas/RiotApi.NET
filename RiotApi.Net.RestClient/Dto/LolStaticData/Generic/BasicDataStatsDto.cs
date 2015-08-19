using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Generic
{
    /// <summary>
    /// This object contains basic data stats.
    /// </summary>
    [DataContract]
    public class BasicDataStatsDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "FlatArmorMod")]
        public double FlatArmorMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "FlatAttackSpeedMod")]
        public double FlatAttackSpeedMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "FlatBlockMod")]
        public double FlatBlockMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "FlatCritChanceMod")]
        public double FlatCritChanceMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "FlatCritDamageMod")]
        public double FlatCritDamageMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "FlatEXPBonus")]
        public double FlatEXPBonus { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "FlatEnergyPoolMod")]
        public double FlatEnergyPoolMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "FlatEnergyRegenMod")]
        public double FlatEnergyRegenMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "FlatHPPoolMod")]
        public double FlatHPPoolMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "FlatHPRegenMod")]
        public double FlatHPRegenMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "FlatMPPoolMod")]
        public double FlatMPPoolMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "FlatMPRegenMod")]
        public double FlatMPRegenMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "FlatMagicDamageMod")]
        public double FlatMagicDamageMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "FlatMovementSpeedMod")]
        public double FlatMovementSpeedMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "FlatPhysicalDamageMod")]
        public double FlatPhysicalDamageMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "FlatSpellBlockMod")]
        public double FlatSpellBlockMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "PercentAttackSpeedMod")]
        public double PercentAttackSpeedMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "PercentBlockMod")]
        public double PercentBlockMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "PercentCritChanceMod")]
        public double PercentCritChanceMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "PercentCritDamageMod")]
        public double PercentCritDamageMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "PercentDodgeMod")]
        public double PercentDodgeMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "PercentEXPBonus")]
        public double PercentEXPBonus { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "PercentHPPoolMod")]
        public double PercentHPPoolMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "PercentHPRegenMod")]
        public double PercentHPRegenMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "PercentLifeStealMod")]
        public double PercentLifeStealMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "PercentMPPoolMod")]
        public double PercentMPPoolMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "PercentMPRegenMod")]
        public double PercentMPRegenMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "PercentMagicDamageMod")]
        public double PercentMagicDamageMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "PercentMovementSpeedMod")]
        public double PercentMovementSpeedMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "PercentPhysicalDamageMod")]
        public double PercentPhysicalDamageMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "PercentSpellBlockMod")]
        public double PercentSpellBlockMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "PercentSpellVampMod")]
        public double PercentSpellVampMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatArmorModPerLevel")]
        public double RFlatArmorModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatArmorPenetrationMod")]
        public double RFlatArmorPenetrationMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatArmorPenetrationModPerLevel")]
        public double RFlatArmorPenetrationModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatCritChanceModPerLevel")]
        public double RFlatCritChanceModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatCritDamageModPerLevel")]
        public double RFlatCritDamageModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatDodgeMod")]
        public double RFlatDodgeMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatDodgeModPerLevel")]
        public double RFlatDodgeModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatEnergyModPerLevel")]
        public double RFlatEnergyModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatEnergyRegenModPerLevel")]
        public double RFlatEnergyRegenModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatGoldPer10Mod")]
        public double RFlatGoldPer10Mod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatHPModPerLevel")]
        public double RFlatHPModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatHPRegenModPerLevel")]
        public double RFlatHPRegenModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatMPModPerLevel")]
        public double RFlatMPModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatMPRegenModPerLevel")]
        public double RFlatMPRegenModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatMagicDamageModPerLevel")]
        public double RFlatMagicDamageModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatMagicPenetrationMod")]
        public double RFlatMagicPenetrationMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatMagicPenetrationModPerLevel")]
        public double RFlatMagicPenetrationModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatMovementSpeedModPerLevel")]
        public double RFlatMovementSpeedModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatPhysicalDamageModPerLevel")]
        public double RFlatPhysicalDamageModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatSpellBlockModPerLevel")]
        public double RFlatSpellBlockModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatTimeDeadMod")]
        public double RFlatTimeDeadMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rFlatTimeDeadModPerLevel")]
        public double RFlatTimeDeadModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rPercentArmorPenetrationMod")]
        public double RPercentArmorPenetrationMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rPercentArmorPenetrationModPerLevel")]
        public double RPercentArmorPenetrationModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rPercentAttackSpeedModPerLevel")]
        public double RPercentAttackSpeedModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rPercentCooldownMod")]
        public double RPercentCooldownMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rPercentCooldownModPerLevel")]
        public double RPercentCooldownModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rPercentMagicPenetrationMod")]
        public double RPercentMagicPenetrationMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rPercentMagicPenetrationModPerLevel")]
        public double RPercentMagicPenetrationModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rPercentMovementSpeedModPerLevel")]
        public double RPercentMovementSpeedModPerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rPercentTimeDeadMod")]
        public double RPercentTimeDeadMod { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rPercentTimeDeadModPerLevel")]
        public double RPercentTimeDeadModPerLevel { get; set; }
    }
}
