﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class BaseModules
    {
        public static IntPtr Client;
        public static IntPtr Engine;
    }

    //put signatures from https://github.com/frk1/hazedumper/blob/master/csgo.cs here, or implement a sig scanner
    class Offsets
    {

        public const Int32 cs_gamerules_data = 0x0;

        public const Int32 m_ArmorValue = 0xB328;

        public const Int32 m_Collision = 0x31C;

        public const Int32 m_CollisionGroup = 0x474;

        public const Int32 m_Local = 0x2FBC;

        public const Int32 m_MoveType = 0x25C;

        public const Int32 m_OriginalOwnerXuidHigh = 0x31B4;

        public const Int32 m_OriginalOwnerXuidLow = 0x31B0;

        public const Int32 m_SurvivalGameRuleDecisionTypes = 0x1318;

        public const Int32 m_SurvivalRules = 0xCF0;

        public const Int32 m_aimPunchAngle = 0x302C;

        public const Int32 m_aimPunchAngleVel = 0x3038;

        public const Int32 m_bBombPlanted = 0x99D;

        public const Int32 m_bFreezePeriod = 0x20;

        public const Int32 m_bGunGameImmunity = 0x3928;

        public const Int32 m_bHasDefuser = 0xB338;

        public const Int32 m_bHasHelmet = 0xB31C;

        public const Int32 m_bInReload = 0x3285;

        public const Int32 m_bIsDefusing = 0x3914;

        public const Int32 m_bIsQueuedMatchmaking = 0x74;

        public const Int32 m_bIsScoped = 0x390A;

        public const Int32 m_bIsValveDS = 0x75;

        public const Int32 m_bSpotted = 0x93D;

        public const Int32 m_bSpottedByMask = 0x980;

        public const Int32 m_clrRender = 0x70;

        public const Int32 m_dwBoneMatrix = 0x26A8;

        public const Int32 m_fAccuracyPenalty = 0x3304;

        public const Int32 m_fFlags = 0x104;

        public const Int32 m_flC4Blow = 0x2990;

        public const Int32 m_flDefuseCountDown = 0x29AC;

        public const Int32 m_flDefuseLength = 0x29A8;

        public const Int32 m_flFallbackWear = 0x31C0;

        public const Int32 m_flFlashDuration = 0xA3E0;

        public const Int32 m_flFlashMaxAlpha = 0xA3DC;

        public const Int32 m_flNextPrimaryAttack = 0x3218;

        public const Int32 m_flTimerLength = 0x2994;

        public const Int32 m_hActiveWeapon = 0x2EF8;

        public const Int32 m_hMyWeapons = 0x2DF8;

        public const Int32 m_hObserverTarget = 0x3388;

        public const Int32 m_hOwner = 0x29CC;

        public const Int32 m_hOwnerEntity = 0x14C;

        public const Int32 m_iAccountID = 0x2FC8;

        public const Int32 m_iClip1 = 0x3244;

        public const Int32 m_iCompetitiveRanking = 0x1A84;

        public const Int32 m_iCompetitiveWins = 0x1B88;

        public const Int32 m_iCrosshairId = 0xB394;

        public const Int32 m_iEntityQuality = 0x2FAC;

        public const Int32 m_iFOV = 0x31E4;

        public const Int32 m_iFOVStart = 0x31E8;

        public const Int32 m_iGlowIndex = 0xA3F8;

        public const Int32 m_iHealth = 0x100;

        public const Int32 m_iItemDefinitionIndex = 0x2FAA;

        public const Int32 m_iItemIDHigh = 0x2FC0;

        public const Int32 m_iObserverMode = 0x3374;

        public const Int32 m_iShotsFired = 0xA370;

        public const Int32 m_iState = 0x3238;

        public const Int32 m_iTeamNum = 0xF4;

        public const Int32 m_lifeState = 0x25F;

        public const Int32 m_nFallbackPaintKit = 0x31B8;

        public const Int32 m_nFallbackSeed = 0x31BC;

        public const Int32 m_nFallbackStatTrak = 0x31C4;

        public const Int32 m_nForceBone = 0x268C;

        public const Int32 m_nTickBase = 0x342C;

        public const Int32 m_rgflCoordinateFrame = 0x444;

        public const Int32 m_szCustomName = 0x303C;

        public const Int32 m_szLastPlaceName = 0x35B0;

        public const Int32 m_thirdPersonViewAngles = 0x31D8;

        public const Int32 m_vecOrigin = 0x138;

        public const Int32 m_vecVelocity = 0x114;

        public const Int32 m_vecViewOffset = 0x108;

        public const Int32 m_viewPunchAngle = 0x3020;
        
        public const Int32 clientstate_choked_commands = 0x4CB0;

        public const Int32 clientstate_delta_ticks = 0x174;

        public const Int32 clientstate_last_outgoing_command = 0x4CAC;

        public const Int32 clientstate_net_channel = 0x9C;

        public const Int32 convar_name_hash_table = 0x2F0F8;

        public const Int32 dwClientState = 0x58ACFC;

        public const Int32 dwClientState_GetLocalPlayer = 0x180;

        public const Int32 dwClientState_IsHLTV = 0x4CC8;

        public const Int32 dwClientState_Map = 0x28C;

        public const Int32 dwClientState_MapDirectory = 0x188;

        public const Int32 dwClientState_MaxPlayer = 0x310;

        public const Int32 dwClientState_PlayerInfo = 0x5240;

        public const Int32 dwClientState_State = 0x108;

        public const Int32 dwClientState_ViewAngles = 0x4D10;

        public const Int32 dwEntityList = 0x4CCDCBC;

        public const Int32 dwForceAttack = 0x30FF378;

        public const Int32 dwForceAttack2 = 0x30FF384;

        public const Int32 dwForceBackward = 0x30FF3CC;

        public const Int32 dwForceForward = 0x30FF3D8;

        public const Int32 dwForceJump = 0x5170E70;

        public const Int32 dwForceLeft = 0x30FF3F0;

        public const Int32 dwForceRight = 0x30FF3E4;

        public const Int32 dwGameDir = 0x630E70;

        public const Int32 dwGameRulesProxy = 0x51E31A4;

        public const Int32 dwGetAllClasses = 0xCE19AC;

        public const Int32 dwGlobalVars = 0x58AA00;

        public const Int32 dwGlowObjectManager = 0x520DAE0;

        public const Int32 dwInput = 0x5118A50;

        public const Int32 dwInterfaceLinkList = 0x89E994;

        public const Int32 dwLocalPlayer = 0xCBD6A4;

        public const Int32 dwMouseEnable = 0xCC31F0;

        public const Int32 dwMouseEnablePtr = 0xCC31C0;

        public const Int32 dwPlayerResource = 0x30FD71C;

        public const Int32 dwRadarBase = 0x51029FC;

        public const Int32 dwSensitivity = 0xCC308C;

        public const Int32 dwSensitivityPtr = 0xCC3060;

        public const Int32 dwSetClanTag = 0x895D0;

        public const Int32 dwViewMatrix = 0x4CBF6D4;

        public const Int32 dwWeaponTable = 0x5119514;

        public const Int32 dwWeaponTableIndex = 0x323C;

        public const Int32 dwYawPtr = 0xCC2E50;

        public const Int32 dwZoomSensitivityRatioPtr = 0xCC8090;

        public const Int32 dwbSendPackets = 0xD21CA;

        public const Int32 dwppDirect3DDevice9 = 0xA3FC0;

        public const Int32 interface_engine_cvar = 0x3E9EC;

        public const Int32 m_bDormant = 0xED;

        public const Int32 m_pStudioHdr = 0x294C;

        public const Int32 m_pitchClassPtr = 0x5102CB0;

        public const Int32 m_yawClassPtr = 0xCC2E50;

        public const Int32 model_ambient_min = 0x58DD1C;
    }
}
