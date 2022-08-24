namespace FgoExportedConstants
{
    static public class ActionType
    {
        public enum Type
        {
            TALK = 1,
            SYSTEM_WINDOW = 2,
            SCROLL_MISSION = 3,
            TRANSITION_TERMINAL = 4,
            VOICE = 5,
            IMAGE_WINDOW = 6,
            MASTER_MISSION_VOICE = 7,
            WAIT_VOICE = 8
        }
    }

    static public class Ai
    {
        public enum COND
        {
            NONE = 0,
            HP_HIGHER = 10,
            HP_LOWER = 11,
            ACTCOUNT = 20,
            ACTCOUNT_MULTIPLE = 21,
            TURN = 30,
            TURN_MULTIPLE = 31,
            BEFORE_ACT_ID = 40,
            BEFORE_ACT_TYPE = 41,
            BEFORE_NOT_ACT_ID = 42,
            BEFORE_NOT_ACT_TYPE = 43,
            CHECK_SELF_BUFF = 50,
            CHECK_SELF_INDIVIDUALITY = 51,
            CHECK_PT_BUFF = 52,
            CHECK_PT_INDIVIDUALITY = 53,
            CHECK_OPPONENT_BUFF = 55,
            CHECK_OPPONENT_INDIVIDUALITY = 56,
            CHECK_SELF_BUFF_INDIVIDUALITY = 57,
            CHECK_PT_BUFF_INDIVIDUALITY = 58,
            CHECK_OPPONENT_BUFF_INDIVIDUALITY = 59,
            CHECK_SELF_NPTURN = 60,
            CHECK_PT_LOWER_NPTURN = 61,
            CHECK_OPPONENT_HEIGHT_NPGAUGE = 62,
            ACTCOUNT_THISTURN = 63,
            CHECK_PT_HP_HIGHER = 64,
            CHECK_PT_HP_LOWER = 65,
            CHECK_SELF_NOT_BUFF_INDIVIDUALITY = 66,
            TURN_AND_ACTCOUNT_THISTURN = 67,
            FIELDTURN = 68,
            FIELDTURN_MULTIPLE = 69,
            CHECK_PT_LOWER_TDTURN = 70,
            RAID_HP_HIGHER = 71,
            RAID_HP_LOWER = 72,
            RAID_COUNT_HIGHER = 73,
            RAID_COUNT_LOWER = 74,
            RAID_COUNT_VALUE_HIGHER = 75,
            RAID_COUNT_VALUE_LOWER = 76,
            CHECK_SPACE = 77,
            TURN_HIGHER = 78,
            TURN_LOWER = 79,
            CHARACTOR_TURN_HIGHER = 80,
            CHARACTOR_TURN_LOWER = 81,
            COUNT_ALIVE_PT = 82,
            COUNT_ALIVE_OPPONENT = 83,
            COUNT_PT_REST_HIGHER = 84,
            COUNT_PT_REST_LOWER = 85,
            COUNT_OPPONENT_REST_HIGHER = 86,
            COUNT_OPPONENT_REST_LOWER = 87,
            COUNT_ITEM_HIGHER = 88,
            COUNT_ITEM_LOWER = 89,
            CHECK_SELF_BUFFCOUNT_INDIVIDUALITY = 90,
            CHECK_PT_BUFFCOUNT_INDIVIDUALITY = 91,
            CHECK_SELF_BUFF_ACTIVE = 92,
            CHECK_PT_BUFF_ACTIVE = 93,
            CHECK_OPPONENT_BUFF_ACTIVE = 94,
            COUNT_ENEMY_COMMAND_SPELL_HIGHER = 95,
            CHECK_PT_ALL_INDIVIDUALITY = 96,
            CHECK_OPPONENT_ALL_INDIVIDUALITY = 97,
            STAR_HIGHER = 98,
            STAR_LOWER = 99,
            CHECK_OPPONENT_HP_HIGHER = 100,
            CHECK_OPPONENT_HP_LOWER = 101,
            CHECK_TARGET_POSITION = 102,
            CHECK_SELF_BUFF_ACTIVE_AND_PASSIVE_INDIVIDUALITY = 103,
            CHECK_PT_BUFF_ACTIVE_AND_PASSIVE_INDIVIDUALITY = 104,
            CHECK_OPPONENT_BUFF_ACTIVE_AND_PASSIVE_INDIVIDUALITY = 105,
            CHECK_PT_ALL_BUFF = 106,
            CHECK_OPPONENT_ALL_BUFF = 107,
            CHECK_PT_ALL_BUFF_INDIVIDUALITY = 108,
            CHECK_OPPONENT_ALL_BUFF_INDIVIDUALITY = 109,
            COUNT_ALIVE_PT_ALL = 110,
            COUNT_ALIVE_OPPONENT_ALL = 111,
            CHECK_PT_ALL_BUFF_ACTIVE = 112,
            CHECK_OPPONENT_ALL_BUFF_ACTIVE = 113,
            COUNT_HIGHER_BUFF_INDIVIDUALITY_SUM_PT = 114,
            COUNT_HIGHER_BUFF_INDIVIDUALITY_SUM_PT_ALL = 115,
            COUNT_HIGHER_BUFF_INDIVIDUALITY_SUM_OPPONENT = 116,
            COUNT_HIGHER_BUFF_INDIVIDUALITY_SUM_OPPONENT_ALL = 117,
            COUNT_HIGHER_BUFF_INDIVIDUALITY_SUM_SELF = 118,
            COUNT_LOWER_BUFF_INDIVIDUALITY_SUM_PT = 119,
            COUNT_LOWER_BUFF_INDIVIDUALITY_SUM_PT_ALL = 120,
            COUNT_LOWER_BUFF_INDIVIDUALITY_SUM_OPPONENT = 121,
            COUNT_LOWER_BUFF_INDIVIDUALITY_SUM_OPPONENT_ALL = 122,
            COUNT_LOWER_BUFF_INDIVIDUALITY_SUM_SELF = 123,
            COUNT_EQUAL_BUFF_INDIVIDUALITY_SUM_PT = 124,
            COUNT_EQUAL_BUFF_INDIVIDUALITY_SUM_PT_ALL = 125,
            COUNT_EQUAL_BUFF_INDIVIDUALITY_SUM_OPPONENT = 126,
            COUNT_EQUAL_BUFF_INDIVIDUALITY_SUM_OPPONENT_ALL = 127,
            COUNT_EQUAL_BUFF_INDIVIDUALITY_SUM_SELF = 128,
            EXIST_INDIVIDUALITY_OPPONENT_FRONT = 129,
            EXIST_INDIVIDUALITY_OPPONENT_CENTER = 130,
            EXIST_INDIVIDUALITY_OPPONENT_BACK = 131,
            TOTAL_COUNT_HIGHER_INDIVIDUALITY_PT = 132,
            TOTAL_COUNT_HIGHER_INDIVIDUALITY_PT_ALL = 133,
            TOTAL_COUNT_HIGHER_INDIVIDUALITY_OPPONENT = 134,
            TOTAL_COUNT_HIGHER_INDIVIDUALITY_OPPONENT_ALL = 135,
            TOTAL_COUNT_HIGHER_INDIVIDUALITY_ALL_FIELD = 136,
            TOTAL_COUNT_LOWER_INDIVIDUALITY_PT = 137,
            TOTAL_COUNT_LOWER_INDIVIDUALITY_PT_ALL = 138,
            TOTAL_COUNT_LOWER_INDIVIDUALITY_OPPONENT = 139,
            TOTAL_COUNT_LOWER_INDIVIDUALITY_OPPONENT_ALL = 140,
            TOTAL_COUNT_LOWER_INDIVIDUALITY_ALL_FIELD = 141,
            TOTAL_COUNT_EQUAL_INDIVIDUALITY_PT = 142,
            TOTAL_COUNT_EQUAL_INDIVIDUALITY_PT_ALL = 143,
            TOTAL_COUNT_EQUAL_INDIVIDUALITY_OPPONENT = 144,
            TOTAL_COUNT_EQUAL_INDIVIDUALITY_OPPONENT_ALL = 145,
            TOTAL_COUNT_EQUAL_INDIVIDUALITY_ALL_FIELD = 146,
            PT_FRONT_DEAD_EQUAL = 147,
            PT_CENTER_DEAD_EQUAL = 148,
            PT_BACK_DEAD_EQUAL = 149,
            COUNT_HIGHER_INDIVIDUALITY_PT_FRONT = 150,
            COUNT_HIGHER_INDIVIDUALITY_PT_CENTER = 151,
            COUNT_HIGHER_INDIVIDUALITY_PT_BACK = 152,
            COUNT_HIGHER_INDIVIDUALITY_OPPONENT_FRONT = 153,
            COUNT_HIGHER_INDIVIDUALITY_OPPONENT_CENTER = 154,
            COUNT_HIGHER_INDIVIDUALITY_OPPONENT_BACK = 155,
            COUNT_LOWER_INDIVIDUALITY_PT_FRONT = 156,
            COUNT_LOWER_INDIVIDUALITY_PT_CENTER = 157,
            COUNT_LOWER_INDIVIDUALITY_PT_BACK = 158,
            COUNT_LOWER_INDIVIDUALITY_OPPONENT_FRONT = 159,
            COUNT_LOWER_INDIVIDUALITY_OPPONENT_CENTER = 160,
            COUNT_LOWER_INDIVIDUALITY_OPPONENT_BACK = 161,
            COUNT_EQUAL_INDIVIDUALITY_PT_FRONT = 162,
            COUNT_EQUAL_INDIVIDUALITY_PT_CENTER = 163,
            COUNT_EQUAL_INDIVIDUALITY_PT_BACK = 164,
            COUNT_EQUAL_INDIVIDUALITY_OPPONENT_FRONT = 165,
            COUNT_EQUAL_INDIVIDUALITY_OPPONENT_CENTER = 166,
            COUNT_EQUAL_INDIVIDUALITY_OPPONENT_BACK = 167,
            CHECK_PRECEDING_ENEMY = 168,
            COUNT_HIGHER_REMAIN_TURN = 169,
            COUNT_LOWER_REMAIN_TURN = 170,
            COUNT_HIGHER_AI_171 = 171,
            COUNT_LOWER_AI_172 = 172,
            COUNT_EQUAL_AI_173 = 173,
            CHECK_AI_174 = 174,
            CHECK_SELF_NPTURN_HIGHER = 175,
            CHECK_SELF_NPTURN_LOWER = 176,
            CHECK_USE_SKILL_THISTURN = 177,
            COUNT_CHAIN_HIGHER = 178,
            COUNT_CHAIN_LOWER = 179,
            COUNT_CHAIN_EQUAL = 180,
            CHECK_SELECT_CHAIN = 181
        }

        public enum ACT_NUM
        {
            NOMAL = 0,
            ANYTIME = -1,
            REACTION_ENEMYTURN_START = -4,
            REACTION_ENEMYTURN_END = -5,
            REACTION_DEAD = -6,
            REACTION_PLAYERACTIONEND = -7,
            REACTION_WAVESTART = -8,
            MAXNP = -9,
            SHIFT_SARVANT_AFTER = -10,
            USENP_TARGET = -11,
            REACTION_TURNSTART = -12,
            REACTION_PLAYERACTIONSTART = -13,
            REACTION_ENTRY_UNIT = -14,
            REACTION_BEFORE_RESURRECTION = -15,
            REACTION_BEFORE_DEAD = -16,
            REACTION_ENEMY_TURN_START_PRIORITY = -401,
            REACTION_ENEMY_TURN_END_PRIORITY = -501
        }

        public enum TIMING
        {
            NONE = 0,
            ANYTIME = -1,
            REACTION_DAMAGE = -2,
            REACTION_SKILL = -3,
            REACTION_ENEMYTURN_START = -4,
            REACTION_ENEMYTURN_END = -5,
            REACTION_DEAD = -6,
            REACTION_PLAYERACTIONEND = -7,
            REACTION_WAVESTART = -8,
            MAXNP = -9,
            WAVE_START = 1,
            TURN_START = 2,
            TURN_PLAYER_START = 3,
            TURN_PLAYER_END = 4,
            TURN_ENEMY_START = 5,
            TURN_ENEMY_END = 6,
            ENTRY_UNIT = 7
        }
    }

    static public class AiAct
    {
        public enum TYPE
        {
            NONE = 0,
            RANDOM = 1,
            ATTACK = 2,
            SKILL_RANDOM = 10,
            SKILL1 = 11,
            SKILL2 = 12,
            SKILL3 = 13,
            PLAY_MOTION = 71,
            NOBLE_PHANTASM = 80,
            CHANGE_THINKING = 99,
            ATTACK_CRITICAL = 30,
            SKILL_ID = 40,
            BATTLE_END = 90,
            LOSE_END = 91,
            ATTACK_A = 14,
            ATTACK_B = 15,
            ATTACK_Q = 16,
            ATTACK_A_CRITICAL = 17,
            ATTACK_B_CRITICAL = 18,
            ATTACK_Q_CRITICAL = 19,
            SKILL_ID_CHECKBUFF = 41,
            RESURRECTION = 42,
            MESSAGE = 72,
            MESSAGE_GROUP = 73
        }

        public enum TARGET
        {
            NONE = 0,
            RANDOM = 1,
            HP_HIGHER = 2,
            HP_LOWER = 3,
            NPTURN_LOWER = 10,
            NPGAUGE_HIGHER = 11,
            REVENGE = 12,
            INDIVIDUALITY_ACTIVE = 13,
            BUFF_ACTIVE = 14,
            FRONT = 15,
            CENTER = 16,
            BACK = 17
        }
    }

    public class AiFieldEntity
    {
        public enum EffectType
        {
            NONE = 0,
            ENEMY_MASTER = 1,
            ENEMY_MASTER_COMMAND_SPELL = 2
        }
    }

    public class BannerAddEntity
    {
        public enum DispType
        {
            EVENT_BANNER = 1,
            EVENT_SHOP_BANNER = 2
        }
    }

    public class BannerEntity
    {
        public enum LinkType
        {
            WEBVIEW = 1,
            APPLI = 2,
            DIALOG = 3
        }
    }

    static public class BattleCommand
    {
        public enum TYPE
        {
            NONE = 0,
            ARTS = 1,
            BUSTER = 2,
            QUICK = 3,
            ADDATTACK = 4,
            BLANK = 5,
            WEAK = 10,
            STRENGTH = 11
        }
    }

    static public class BattleDataDefine
    {
        public enum FieldActorPosition
        {
            FRONT = 0,
            CENTER = 1,
            BACK = 2
        }

        public enum RaidType
        {
            NONE = 0,
            RAID = 1,
            SUPER_BOSS = 2
        }
    }

    static public class BattleDebug
    {
        public enum TAG
        {
            NONE = 0,
            SKILL = 1,
            ACTION = 2,
            FUNCTION = 3,
            AI = 4,
            ANIMATION = 5,
            KEISAN = 6,
            PRINT = 7,
            BUFF = 8,
            PERF = 9,
            LOGIC = 10,
            NEW_AI = 11,
            DEBUG = 100,
            WARNING = 101,
            ERROR = 102
        }
    }

    static public class BattleEffectUtility
    {
        public enum EffectFolderType
        {
            COMMON = 1,
            NOBLE = 2,
            WEAPON = 3,
            BATTLEASSET = 4,
            BATTLECOMMON = 5
        }
    }

    public class BgmEntity
    {
        public enum Flag
        {
            IS_NOT_RELEASE = 1
        }
    }

    public class BoardMessageEntity
    {
        public enum ReferenceType
        {
            MESSAGE_CLOSE = 1,
            QUEST_OPEN = 2,
            QUEST_CLOSE = 3,
            EVENT_CLOSE = 4,
            DAILY_DROP_UP = 5
        }
    }

    public class BoxGachaEntity
    {
        public enum Flag
        {
            NONE = 1,
            LIMIT_RESET = 2
        }
    }

    public class BuffEntity
    {
        public enum CheckIndvType
        {
            OR_TYPE = 0,
            AND_TYPE = 1,
            BOTH_OR_TYPE = 2,
            BOTH_AND_TYPE = 3
        }
    }

    static public class BuffList
    {
        public enum TYPE
        {
            NONE = 0,
            UP_COMMANDATK = 1,
            UP_STARWEIGHT = 2,
            UP_CRITICALPOINT = 3,
            DOWN_CRITICALPOINT = 4,
            REGAIN_NP = 5,
            REGAIN_STAR = 6,
            REGAIN_HP = 7,
            REDUCE_HP = 8,
            UP_ATK = 9,
            DOWN_ATK = 10,
            UP_DAMAGE = 11,
            DOWN_DAMAGE = 12,
            ADD_DAMAGE = 13,
            SUB_DAMAGE = 14,
            UP_NPDAMAGE = 15,
            DOWN_NPDAMAGE = 16,
            UP_DROPNP = 17,
            UP_CRITICALDAMAGE = 18,
            DOWN_CRITICALDAMAGE = 19,
            UP_SELFDAMAGE = 20,
            DOWN_SELFDAMAGE = 21,
            ADD_SELFDAMAGE = 22,
            SUB_SELFDAMAGE = 23,
            AVOIDANCE = 24,
            BREAK_AVOIDANCE = 25,
            INVINCIBLE = 26,
            UP_GRANTSTATE = 27,
            DOWN_GRANTSTATE = 28,
            UP_TOLERANCE = 29,
            DOWN_TOLERANCE = 30,
            AVOID_STATE = 31,
            DONOT_ACT = 32,
            DONOT_SKILL = 33,
            DONOT_NOBLE = 34,
            DONOT_RECOVERY = 35,
            DISABLE_GENDER = 36,
            GUTS = 37,
            UP_HATE = 38,
            ADD_INDIVIDUALITY = 40,
            SUB_INDIVIDUALITY = 41,
            UP_DEFENCE = 42,
            DOWN_DEFENCE = 43,
            UP_COMMANDSTAR = 50,
            UP_COMMANDNP = 51,
            UP_COMMANDALL = 52,
            DOWN_COMMANDALL = 60,
            DOWN_STARWEIGHT = 61,
            REDUCE_NP = 62,
            DOWN_DROPNP = 63,
            UP_GAIN_HP = 64,
            DOWN_GAIN_HP = 65,
            DOWN_COMMANDATK = 66,
            DOWN_COMMANSTAR = 67,
            DOWN_COMMANDNP = 68,
            UP_CRITICALRATE = 70,
            DOWN_CRITICALRATE = 71,
            PIERCE_INVINCIBLE = 72,
            AVOID_INSTANTDEATH = 73,
            UP_RESIST_INSTANTDEATH = 74,
            UP_NONRESIST_INSTANTDEATH = 75,
            DELAY_FUNCTION = 76,
            REGAIN_NP_USED_NOBLE = 77,
            DEAD_FUNCTION = 78,
            UP_MAXHP = 79,
            DOWN_MAXHP = 80,
            ADD_MAXHP = 81,
            SUB_MAXHP = 82,
            BATTLESTART_FUNCTION = 83,
            WAVESTART_FUNCTION = 84,
            SELFTURNEND_FUNCTION = 85,
            UP_GIVEGAIN_HP = 87,
            DOWN_GIVEGAIN_HP = 88,
            COMMANDATTACK_FUNCTION = 89,
            DEADATTACK_FUNCTION = 90,
            UP_SPECIALDEFENCE = 91,
            DOWN_SPECIALDEFENCE = 92,
            UP_DAMAGEDROPNP = 93,
            DOWN_DAMAGEDROPNP = 94,
            ENTRY_FUNCTION = 95,
            UP_CHAGETD = 96,
            REFLECTION_FUNCTION = 97,
            UP_GRANT_SUBSTATE = 98,
            DOWN_GRANT_SUBSTATE = 99,
            UP_TOLERANCE_SUBSTATE = 100,
            DOWN_TOLERANCE_SUBSTATE = 101,
            UP_GRANT_INSTANTDEATH = 102,
            DOWN_GRANT_INSTANTDEATH = 103,
            GUTS_RATIO = 104,
            DAMAGE_FUNCTION = 86,
            UP_DEFENCECOMMANDALL = 105,
            DOWN_DEFENCECOMMANDALL = 106,
            OVERWRITE_BATTLECLASS = 107,
            OVERWRITE_CLASSRELATIO_ATK = 108,
            OVERWRITE_CLASSRELATIO_DEF = 109,
            UP_DAMAGE_INDIVIDUALITY = 110,
            DOWN_DAMAGE_INDIVIDUALITY = 111,
            UP_DAMAGE_INDIVIDUALITY_ACTIVEONLY = 112,
            DOWN_DAMAGE_INDIVIDUALITY_ACTIVEONLY = 113,
            UP_NPTURNVAL = 114,
            DOWN_NPTURNVAL = 115,
            MULTIATTACK = 116,
            UP_GIVE_NP = 117,
            DOWN_GIVE_NP = 118,
            UP_RESISTANCE_DELAY_NPTURN = 119,
            DOWN_RESISTANCE_DELAY_NPTURN = 120,
            PIERCE_DEFENCE = 121,
            UP_GUTS_HP = 122,
            DOWN_GUTS_HP = 123,
            UP_FUNCGAIN_NP = 124,
            DOWN_FUNCGAIN_NP = 125,
            UP_FUNC_HP_REDUCE = 126,
            DOWN_FUNC_HP_REDUCE = 127,
            UP_DEFENCECOMMAN_DAMAGE = 128,
            DOWN_DEFENCECOMMAN_DAMAGE = 129,
            NPATTACK_PREV_BUFF = 130,
            FIX_COMMANDCARD = 131,
            DONOT_GAINNP = 132,
            FIELD_INDIVIDUALITY = 133,
            DONOT_ACT_COMMANDTYPE = 134,
            UP_DAMAGE_EVENT_POINT = 135,
            UP_DAMAGE_SPECIAL = 136,
            ATTACK_FUNCTION = 137,
            COMMANDCODEATTACK_FUNCTION = 138,
            DONOT_NOBLE_COND_MISMATCH = 139,
            DONOT_SELECT_COMMANDCARD = 140,
            DONOT_REPLACE = 141,
            SHORTEN_USER_EQUIP_SKILL = 142,
            TD_TYPE_CHANGE = 143,
            OVERWRITE_CLASS_RELATION = 144,
            TD_TYPE_CHANGE_ARTS = 145,
            TD_TYPE_CHANGE_BUSTER = 146,
            TD_TYPE_CHANGE_QUICK = 147,
            COMMANDATTACK_BEFORE_FUNCTION = 148,
            GUTS_FUNCTION = 149,
            UP_CRITICAL_RATE_DAMAGE_TAKEN = 150,
            DOWN_CRITICAL_RATE_DAMAGE_TAKEN = 151,
            UP_CRITICAL_STAR_DAMAGE_TAKEN = 152,
            DOWN_CRITICAL_STAR_DAMAGE_TAKEN = 153,
            SKILL_RANK_UP = 154,
            AVOIDANCE_INDIVIDUALITY = 155,
            CHANGE_COMMAND_CARD_TYPE = 156,
            SPECIAL_INVINCIBLE = 157,
            PREVENT_DEATH_BY_DAMAGE = 158,
            COMMANDCODEATTACK_AFTER_FUNCTION = 159,
            ATTACK_BEFORE_FUNCTION = 160,
            DONOT_SKILL_SELECT = 161,
            INVISIBLE_BATTLE_CHARA = 163,
            BUFF_RATE = 162,
            COUNTER_FUNCTION = 165,
            NOT_TARGET_SKILL = 166,
            TO_FIELD_CHANGE_FIELD = 10001,
            TO_FIELD_AVOID_BUFF = 10002
        }

        public enum LIMIT
        {
            NONE = 0,
            UPPER = 1,
            LOWER = 2,
            NORMAL = 3
        }

        public enum ACTION
        {
            NONE = 0,
            COMMAND_ATK = 1,
            COMMAND_DEF = 2,
            ATK = 3,
            DEFENCE = 4,
            DEFENCE_PIERCE = 5,
            SPECIALDEFENCE = 6,
            DAMAGE = 7,
            DAMAGE_INDIVIDUALITY = 8,
            DAMAGE_INDIVIDUALITY_ACTIVEONLY = 9,
            SELFDAMAGE = 10,
            CRITICAL_DAMAGE = 11,
            NPDAMAGE = 12,
            GIVEN_DAMAGE = 13,
            RECEIVE_DAMAGE = 14,
            PIERCE_INVINCIBLE = 15,
            INVINCIBLE = 16,
            BREAK_AVOIDANCE = 17,
            AVOIDANCE = 18,
            OVERWRITE_BATTLECLASS = 19,
            OVERWRITE_CLASSRELATIO_ATK = 20,
            OVERWRITE_CLASSRELATIO_DEF = 21,
            COMMAND_NP_ATK = 22,
            COMMAND_NP_DEF = 23,
            DROP_NP = 24,
            DROP_NP_DAMAGE = 25,
            COMMAND_STAR_ATK = 26,
            COMMAND_STAR_DEF = 27,
            CRITICAL_POINT = 28,
            STARWEIGHT = 29,
            TURNEND_NP = 30,
            TURNEND_STAR = 31,
            TURNEND_HP_REGAIN = 32,
            TURNEND_HP_REDUCE = 33,
            GAIN_HP = 34,
            TURNVAL_NP = 35,
            GRANT_STATE = 36,
            RESISTANCE_STATE = 37,
            AVOID_STATE = 38,
            DONOT_ACT = 39,
            DONOT_SKILL = 40,
            DONOT_NOBLE = 41,
            DONOT_RECOVERY = 42,
            INDIVIDUALITY_ADD = 43,
            INDIVIDUALITY_SUB = 44,
            HATE = 45,
            CRITICAL_RATE = 46,
            AVOID_INSTANTDEATH = 47,
            RESIST_INSTANTDEATH = 48,
            NONRESIST_INSTANTDEATH = 49,
            REGAIN_NP_USED_NOBLE = 50,
            FUNCTION_DEAD = 51,
            MAXHP_RATE = 52,
            MAXHP_VALUE = 53,
            FUNCTION_WAVESTART = 54,
            FUNCTION_SELFTURNEND = 55,
            GIVE_GAIN_HP = 56,
            FUNCTION_COMMANDATTACK = 57,
            FUNCTION_DEADATTACK = 58,
            FUNCTION_ENTRY = 59,
            CHAGETD = 60,
            GRANT_SUBSTATE = 61,
            TOLERANCE_SUBSTATE = 62,
            GRANT_INSTANTDEATH = 63,
            FUNCTION_DAMAGE = 64,
            FUNCTION_REFLECTION = 65,
            MULTIATTACK = 66,
            GIVE_NP = 67,
            RESISTANCE_DELAY_NPTURN = 68,
            PIERCE_DEFENCE = 69,
            GUTS_HP = 70,
            FUNCGAIN_NP = 71,
            FUNC_HP_REDUCE = 72,
            FUNCTION_NPATTACK = 73,
            FIX_COMMANDCARD = 74,
            DONOT_GAINNP = 75,
            FIELD_INDIVIDUALITY = 76,
            DONOT_ACT_COMMANDTYPE = 77,
            DAMAGE_EVENT_POINT = 78,
            DAMAGE_SPECIAL = 79,
            FUNCTION_ATTACK = 80,
            FUNCTION_COMMANDCODEATTACK = 81,
            DONOT_NOBLE_COND_MISMATCH = 82,
            DONOT_SELECT_COMMANDCARD = 83,
            DONOT_REPLACE = 84,
            SHORTEN_USER_EQUIP_SKILL = 85,
            TD_TYPE_CHANGE = 86,
            OVERWRITE_CLASS_RELATION = 87,
            FUNCTION_COMMANDATTACK_BEFORE = 88,
            FUNCTION_GUTS = 89,
            CRITICAL_RATE_DAMAGE_TAKEN = 90,
            CRITICAL_STAR_DAMAGE_TAKEN = 91,
            SKILL_RANK_CHANGE = 92,
            AVOIDANCE_INDIVIDUALITY = 93,
            CHANGE_COMMAND_CARD_TYPE = 94,
            SPECIAL_INVINCIBLE = 95,
            PREVENT_DEATH_BY_DAMAGE = 96,
            FUNCTION_COMMANDCODEATTACK_AFTER = 97,
            FUNCTION_ATTACK_BEFORE = 98,
            DONOT_SKILL_SELECT = 99,
            INVISIBLE_BATTLE_CHARA = 100,
            BUFF_RATE = 101,
            COUNTER_FUNCTION = 102,
            NOT_TARGET_SKILL = 103,
            TO_FIELD_CHANGE_FIELD = 104,
            TO_FIELD_AVOID_BUFF = 105
        }

        public enum DEL_AFTER_TYPE
        {
            NONE = 0,
            UPDATE_FIELD = 1,
            UPDATE_VIEW = 2
        }

        public enum INVOKE_COND_TYPE
        {
            INDIVIDUALITY = 0,
            BUFF_TYPE = 1
        }

        public enum CONDITIONS
        {
            HP_HIGHER = 0,
            HP_LOWER = 1,
            INDIVIDUALITIE = 2
        }

        public enum CHANGEVALUE
        {
            RATIO_HP_HIGH = 0,
            RATIO_HP_LOW = 1
        }

        public enum ProgressTurnCond
        {
            NONE = 0,
            ALIVE_ENEMY_ALLY = 1,
            ALIVE_SELF = 2
        }
    }

    public class ClassRelationOverwriteEntity
    {
        public enum TYPE
        {
            OVERWRITE_FORCE = 0,
            OVERWRITE_MORE_THAN_TARGET = 1,
            OVERWRITE_LESS_THAN_TARGET = 2
        }
    }

    public class CombineEntity
    {
        public enum CombineType
        {
            NORMAL = 1,
            ADD_TOTAL_EXP = 2,
            DEFAULT_MAX_LIMIT_COUNT = 3
        }
    }

    public class CommonConsumeEntity
    {
        public enum CommonConsumeType
        {
            ITEM = 1,
            AP = 2
        }
    }

    static public class CTouch
    {
        public enum TCH_STATE
        {
            NONE = 0,
            PUSH = 1,
            KEEP = 2,
            RELEASE = 3
        }
    }

    static public class Easing
    {
        public enum TYPE
        {
            LINER = 0,
            QUADRATIC_IN = 1,
            QUADRATIC_OUT = 2,
            QUADRATIC_IN_OUT = 3,
            CUBIC_IN = 4,
            CUBIC_OUT = 5,
            CUBIC_IN_OUT = 6,
            QUARTIC_IN = 7,
            QUARTIC_OUT = 8,
            QUARTIC_IN_OUT = 9,
            QUINTIC_IN = 10,
            QUINTIC_OUT = 11,
            QUINTIC_IN_OUT = 12,
            SINUSOIDAL_IN = 13,
            SINUSOIDAL_OUT = 14,
            SINUSOIDAL_IN_OUT = 15,
            EXPONENTIAL_IN = 16,
            EXPONENTIAL_OUT = 17,
            EXPONENTIAL_IN_OUT = 18,
            CIRCULAR_IN = 19,
            CIRCULAR_OUT = 20,
            CIRCULAR_IN_OUT = 21
        }
    }

    public class EventAddEntity
    {
        public enum OverwriteType
        {
            BG_IMAGE = 1,
            BGM = 2,
            NAME = 3,
            BANNER = 4,
            NOTICE_BANNER = 5
        }
    }

    public class EventBoardGameTokenEntity
    {
        public enum EventBoardGameTokenFlag
        {
            FIRST_GAME = 1,
            SECOND_GAME = 2,
            THIRD_GAME = 4,
            FOURTH_GAME = 8,
            FIFTH_GAME = 16,
            SIXTH_GAME = 32
        }
    }

    public class EventBonusFilterEntity
    {
        public enum EventBonusFilterType
        {
            SVT_EQUIP = 1,
            FILTER_GROUP = 2,
            SVT_EQUIP_EXP = 3,
            SVT_BONUS_SKILL = 4,
            SKILL_FILTER_GROUP = 5
        }
    }

    public class EventBuddyPointEntity
    {
        public enum EventBuddyPointFlag
        {
            HIDE_BUDDY_POINT_RESULT = 1,
            NOT_BUDDY_POINT_BUFF = 2
        }
    }

    public class EventCombineEntity
    {
        public enum CalcType
        {
            ADDITION = 1,
            MULTIPLICATION = 2,
            FIXED_VALUE = 3
        }
    }

    public class EventConquestRewardEntity
    {
        public enum GiftType
        {
            NONE = 1,
            ITEM = 2
        }
    }

    public class EventDetailEntity
    {
        public enum EventGaugeType
        {
            NONE = 1,
            NORMAL_RAID = 2,
            LAST_WAR_RAID = 3,
            EVENT_GROUP_POINT = 4,
            RASHOMON_RAID = 5,
            EVENT_RACE = 6
        }

        public enum FlagKind
        {
            TYPE_POINT = 0,
            TYPE_EXCHANGE_SHOP = 1,
            TYPE_BOX_GACHA = 2,
            TYPE_RANKING = 3,
            TYPE_BONUS_SKILL = 4,
            TYPE_MISSION = 5,
            TYPE_RAID = 6,
            TYPE_EVENT_SHOP = 7,
            MATERIAL_ADD_QUEST_GROUP = 8,
            MATERIAL_ADD_EVENT_END = 9,
            SUPER_BOSS = 10,
            RAID_DEFEAT_COUNT = 11,
            BP = 12,
            NO_MATERIAL_BANNER = 13,
            EVENT_POINT = 14,
            EVENT_GROUP_POINT = 15,
            EVENT_VOICE_PLAY = 16,
            DAILY_MISSION = 17,
            EVENT_GROUP_RANKING = 18,
            EVENT_TOWER = 19,
            EVENT_FATIGUE = 20,
            NO_DISP_ARROW = 21,
            FORCED_ADJUSTMENT_DIALOG = 22,
            SHIFT_HELP_INFO = 23,
            CLOSE_PURCHASE_SHOP = 24,
            TIME_STATUS_RECORD = 25,
            USE_EVENT_SUPPORT_DECK = 26,
            EVENT_DAIRY_POINT = 27,
            EVENT_ACTIVITY_POINT = 28,
            EVENT_ONLY_EQUIP = 29,
            MAP_SWITCH_BUTTON_TOP = 30,
            EVENT_REVIVAL = 31,
            EVENT_CONQUEST = 32,
            EVENT_POINT_BY_QP = 33,
            ALL_USERS_BOX_GACHA_COUNT = 34,
            NOT_DISPLAY_BONUS_ON_SUPPORT_SET = 35,
            FRIEND_POINT_BOOST_ITEM = 36,
            EVENT_BOARD_GAME = 37,
            NOT_DISPLAY_DA_VINCI = 38,
            IS_MAIN_INTERLUDE = 39,
            QUEST_COOLTIME = 41,
            EVENT_PANEL = 42,
            EVENT_ASSIST = 43,
            TREASURE_BOX = 44,
            HIDE_AFTER_PURCHASE = 45,
            ALLOUT_BATTLE = 46,
            SPOT_COOLTIME = 47
        }

        public enum Flag : long
        {
            TYPE_POINT = 1L,
            TYPE_EXCHANGE_SHOP = 2L,
            TYPE_BOX_GACHA = 4L,
            TYPE_RANKING = 8L,
            TYPE_BONUS_SKILL = 16L,
            TYPE_MISSION = 32L,
            TYPE_RAID = 64L,
            TYPE_EVENT_SHOP = 128L,
            MATERIAL_ADD_QUEST_GROUP = 256L,
            MATERIAL_ADD_EVENT_END = 512L,
            SUPER_BOSS = 1024L,
            RAID_DEFEAT_COUNT = 2048L,
            BP = 4096L,
            NO_MATERIAL_BANNER = 8192L,
            EVENT_POINT = 16384L,
            EVENT_GROUP_POINT = 32768L,
            EVENT_VOICE_PLAY = 65536L,
            DAILY_MISSION = 131072L,
            EVENT_GROUP_RANKING = 262144L,
            EVENT_TOWER = 524288L,
            EVENT_FATIGUE = 1048576L,
            NO_DISP_ARROW = 2097152L,
            FORCED_ADJUSTMENT_DIALOG = 4194304L,
            SHIFT_HELP_INFO = 8388608L,
            CLOSE_PURCHASE_SHOP = 16777216L,
            TIME_STATUS_RECORD = 33554432L,
            USE_EVENT_SUPPORT_DECK = 67108864L,
            EVENT_DAIRY_POINT = 134217728L,
            EVENT_ACTIVITY_POINT = 268435456L,
            EVENT_ONLY_EQUIP = 536870912L,
            MAP_SWITCH_BUTTON_TOP = 1073741824L,
            EVENT_REVIVAL = 2147483648L,
            EVENT_CONQUEST = 4294967296L,
            EVENT_POINT_BY_QP = 8589934592L,
            ALL_USERS_BOX_GACHA_COUNT = 17179869184L,
            NOT_DISPLAY_BONUS_ON_SUPPORT_SET = 34359738368L,
            FRIEND_POINT_BOOST_ITEM = 68719476736L,
            EVENT_BOARD_GAME = 137438953472L,
            NOT_DISPLAY_DA_VINCI = 274877906944L,
            IS_MAIN_INTERLUDE = 549755813888L,
            QUEST_COOLTIME = 2199023255552L,
            EVENT_PANEL = 4398046511104L,
            EVENT_ASSIST = 8796093022208L,
            TREASURE_BOX = 17592186044416L,
            HIDE_AFTER_PURCHASE = 35184372088832L,
            ALLOUT_BATTLE = 70368744177664L,
            SPOT_COOLTIME = 140737488355328L
        }
    }

    public class EventEntity
    {
        public enum EventOpenType
        {
            ONCE = 1,
            REPEAT = 2
        }
    }

    public class EventFilterEntity
    {
        public enum FlagKind
        {
            SUPPORT_NO_DISPLAY = 1,
            SELECT_SVT_NO_DISPLAY = 2,
            SELECT_EQUIP_NO_DISPLAY = 3,
            SUPPORT_SELECT_SVT_NO_DISPLAY = 4,
            SUPPORT_SELECT_EQUIP_NO_DISPLAY = 5
        }

        public enum FlagMask
        {
            SUPPORT_NO_DISPLAY = 2,
            SELECT_SVT_NO_DISPLAY = 4,
            SELECT_EQUIP_NO_DISPLAY = 8,
            SUPPORT_SELECT_SVT_NO_DISPLAY = 16,
            SUPPORT_SELECT_EQUIP_NO_DISPLAY = 32
        }
    }

    public class EventItemDisplayEntity
    {
        public enum ScreenFlag
        {
            TERMINAL_MAP_REWARD = 2,
            SHOP = 4,
            EVENT_SHOP = 8,
            TERMINAL = 16,
            EVENT_MAP = 32,
            EVENT_REWARD = 64
        }

        public enum DisplayPoinstType
        {
            ITEM = 1,
            EVENT_POINT = 2,
            RAID = 3,
            MISSION = 4
        }
    }

    public class EventMissionConditionEntity
    {
        public enum Flag
        {
            NONE = 1,
            NO_DISPLAY_NOTIFY_BATTLE_OPEN = 2,
            NO_DISPLAY_NOTIFY_BATTLE_START = 4,
            NO_DISPLAY_NOTIFY_BATTLE_PROGRESS = 8,
            NO_DISPLAY_NOTIFY_BATTLE_CLEAR = 16,
            UNLOCK_COND_TEXT_COLOR_CHANGE = 64
        }
    }

    public class EventMissionEntity
    {
        public enum MissionFlag
        {
            NONE = 1,
            CLOSED_HIDE_REWARD = 2,
            IGNORE_START_CONDITION = 8,
            IS_DIRECT_REWARD = 16,
            IS_DAILY = 32
        }
    }

    public class EventPanelMapDetailEntity
    {
        public enum EventPanelMapDetailFlag
        {
            START_SCAN = 1,
            IGNORE_RANDOM_SPOT = 2
        }
    }

    public class EventPanelSpotEntity
    {
        public enum EventPanelSpotType
        {
            NORMAL = 1,
            RANDOM = 2,
            CROSSLINE = 3
        }
    }

    public class EventPointEntity
    {
        public enum Flag
        {
            NONE = 1,
            BOSS_BATTLE = 2
        }
    }

    public class EventPointGroupAddEntity
    {
        public enum OverwriteType
        {
            ICON = 1
        }
    }

    public class EventRewardSceneEntity
    {
        public enum eventType
        {
            EVENT_ITEM = 1,
            BOX_GACHA = 2,
            EVENT_POINT = 3,
            EVENT_MISSION = 4,
            DAMAGE_POINT = 5,
            RACE_RANKING = 6,
            EVENT_TOWER = 7,
            FATIGUE_RECOVERY = 8,
            EVENT_BOARD_GAME_TOKEN = 9,
            TREASURE_BOX = 10,
            RANDOM_MISSION = 11,
            DIGGING_MISSION = 12,
            EVENT_EXPEDITION = 13
        }

        public enum RewardSceneFlag
        {
            IS_NPC_GUIDE = 1,
            IS_CHANGE_SVT_BY_CHANGED_TAB = 2,
            IS_HIDE_TAB = 3
        }

        public enum Flag
        {
            NPC_GUIDE = 2,
            IS_CHANGE_SVT_BY_CHANGED_TAB = 4,
            IS_HIDE_TAB = 8
        }
    }

    public class EventRewardSetEntity
    {
        public enum RewardSetType
        {
            BOX_GACHA = 1,
            EVENT_POINT = 2,
            EVENT_MISSION = 3
        }
    }

    public class EventScriptEntity
    {
        public enum PlayType
        {
            RACE_WIN = 1,
            RACE_RESULT = 2,
            RACE_TOTAL_RESULT = 3
        }
    }

    public class EventServantEntity
    {
        public enum TYPE
        {
            NONE = 0,
            JOIN = 1,
            COND_JOIN = 2,
            DIRECT_JOIN = 3
        }
    }

    public class EventStatusEntity
    {
        public enum EventTimeStatusKind
        {
            IS_SCENARIO = 0,
            IS_NIGHT = 1,
            DAY_1 = 2,
            DAY_2 = 3,
            DAY_3 = 4,
            DAY_4 = 5,
            DAY_5 = 6,
            DAY_6 = 7,
            DAY_7 = 8
        }

        public enum EventTimeStatus
        {
            IS_SCENARIO = 1,
            IS_NIGHT = 2,
            DAY_1 = 4,
            DAY_2 = 8,
            DAY_3 = 16,
            DAY_4 = 32,
            DAY_5 = 64,
            DAY_6 = 128,
            DAY_7 = 256
        }
    }

    public class EventTowerEntity
    {
        public enum Flag
        {
            HIDDEN_CLEAR_TOWER = 1,
            STAMP = 2
        }

        public enum EventTowerFlag
        {
            HIDDEN_CLEAR_TOWER = 0,
            STAMP = 1
        }
    }

    public class EventUiEntity
    {
        public enum ObjectType
        {
            NONE = 1,
            IMAGE = 2,
            GAMEOBJECT = 3
        }

        public enum DispAreaType
        {
            MAP = 1,
            EVENT_REWARD = 2,
            CALDEA_GATE = 4,
            SPOT = 8
        }
    }

    public class EventUiValueEntity
    {
        public enum ValueType
        {
            NONE = 0,
            ITEM = 1,
            EVENT_POINT = 2,
            EVENT_TOWER = 3,
            VALUE_LONG = 4,
            BATTLE_LINE = 5,
            ASSIST = 6
        }
    }

    public class FieldMotionEntity
    {
        public enum Flag
        {
            NOT_START_BATTLE_SKIP = 1
        }
    }

    static public class Follower
    {
        public enum Type
        {
            NONE = 0,
            FRIEND = 1,
            NOT_FRIEND = 2,
            NPC = 3,
            NPC_NO_TD = 4,
            FOLLOW = 5
        }
    }

    static public class FuncList
    {
        public enum TYPE
        {
            NONE = 0,
            ADD_STATE = 1,
            SUB_STATE = 2,
            DAMAGE = 3,
            DAMAGE_NP = 4,
            GAIN_STAR = 5,
            GAIN_HP = 6,
            GAIN_NP = 7,
            LOSS_NP = 8,
            SHORTEN_SKILL = 9,
            EXTEND_SKILL = 10,
            RELEASE_STATE = 11,
            LOSS_HP = 12,
            INSTANT_DEATH = 13,
            DAMAGE_NP_PIERCE = 14,
            DAMAGE_NP_INDIVIDUAL = 15,
            ADD_STATE_SHORT = 16,
            GAIN_HP_PER = 17,
            DAMAGE_NP_STATE_INDIVIDUAL = 18,
            HASTEN_NPTURN = 19,
            DELAY_NPTURN = 20,
            FRIEND_POINT_UP = 104,
            FRIEND_POINT_UP_DUPLICATE = 123,
            EXP_UP = 101,
            QP_UP = 102,
            DROP_UP = 103,
            EVENT_DROP_UP = 105,
            EVENT_DROP_RATE_UP = 106,
            DAMAGE_NP_HPRATIO_HIGH = 21,
            DAMAGE_NP_HPRATIO_LOW = 22,
            EVENT_POINT_UP = 107,
            EVENT_POINT_RATE_UP = 108,
            CARD_RESET = 23,
            REPLACE_MEMBER = 24,
            TRANSFORM_SERVANT = 109,
            QP_DROP_UP = 110,
            SERVANT_FRIENDSHIP_UP = 111,
            USER_EQUIP_EXP_UP = 112,
            CLASS_DROP_UP = 113,
            ENEMY_ENCOUNT_COPY_RATE_UP = 114,
            ENEMY_ENCOUNT_RATE_UP = 115,
            LOSS_HP_SAFE = 25,
            DAMAGE_NP_COUNTER = 26,
            DAMAGE_NP_STATE_INDIVIDUAL_FIX = 27,
            DAMAGE_NP_SAFE = 28,
            CALL_SERVANT = 29,
            PT_SHUFFLE = 30,
            ENEMY_PROB_DOWN = 116,
            LOSS_STAR = 31,
            CHANGE_SERVANT = 32,
            CHANGE_BG = 33,
            DAMAGE_VALUE = 34,
            WITHDRAW = 35,
            FIX_COMMANDCARD = 36,
            SHORTEN_BUFFTURN = 37,
            EXTEND_BUFFTURN = 38,
            SHORTEN_BUFFCOUNT = 39,
            EXTEND_BUFFCOUNT = 40,
            CHANGE_BGM = 41,
            DISPLAY_BUFFSTRING = 42,
            RESURRECTION = 43,
            GAIN_NP_BUFF_INDIVIDUAL_SUM = 44,
            SET_SYSTEM_ALIVE_FLAG = 45,
            FORCE_INSTANT_DEATH = 46,
            DAMAGE_NP_RARE = 47,
            GAIN_NP_FROM_TARGETS = 48,
            GAIN_HP_FROM_TARGETS = 49,
            LOSS_HP_PER = 50,
            LOSS_HP_PER_SAFE = 51,
            SHORTEN_USER_EQUIP_SKILL = 52,
            QUICK_CHANGE_BG = 53,
            SHIFT_SERVANT = 54,
            DAMAGE_NP_AND_CHECK_INDIVIDUALITY = 55,
            ABSORB_NPTURN = 56,
            OVERWRITE_DEAD_TYPE = 57,
            FORCE_ALL_BUFF_NOACT = 58,
            BREAK_GAUGE_UP = 59,
            BREAK_GAUGE_DOWN = 60,
            MOVE_TO_LAST_SUBMEMBER = 61,
            GET_REWARD_GIFT = 117,
            SEND_SUPPORT_FRIEND_POINT = 118,
            MOVE_POSITION = 119,
            REVIVAL = 120,
            DAMAGE_NP_INDIVIDUAL_SUM = 121,
            DAMAGE_VALUE_SAFE = 122,
            MOVE_STATE = 124,
            CHANGE_BGM_COSTUME = 125,
            FUNC_126 = 126,
            FUNC_127 = 127,
            UPDATE_ENTRY_POSITIONS = 128,
            BUDDY_POINT_UP = 129,
            ADD_FIELD_CHANGE_TO_FIELD = 130,
            SUB_FIELD_BUFF = 131
        }

        public enum COND
        {
            NONE = 0,
            INVARIABLY = 1,
            PROB = 2,
            MOREHP = 3,
            LESSHP = 4
        }
    }

    public class FunctionCategoryEntity
    {
        public enum GroupType
        {
            NONE = 0,
            ATTACK = 1,
            DEFENCE = 2,
            STATUS_EFFECT = 3,
            OTHER = 4,
            ATTACK_DEBUFF = 5,
            DEFENCE_DEBUFF = 6,
            STATUS_EFFECT_DEBUFF = 7
        }

        public enum FuncCategoryFlag
        {
            SVT_EQUIP_FILTER = 0,
            COMMAND_CODE_FILTER = 1
        }

        public enum Flag
        {
            SVT_EQUIP_FILTER = 1,
            COMMAND_CODE_FILTER = 2
        }
    }

    public class GachaEntity
    {
        public enum FlagKind
        {
            PC_MESSAGE = 1
        }

        public enum Flag
        {
            PC_MESSAGE = 2
        }
    }

    static public class Gift
    {
        public enum Type
        {
            SERVANT = 1,
            ITEM = 2,
            FRIENDSHIP = 3,
            USER_EXP = 4,
            EQUIP = 5,
            EVENT_SVT_JOIN = 6,
            EVENT_SVT_GET = 7,
            QUEST_REWARD_ICON = 8,
            COSTUME_RELEASE = 9,
            COSTUME_GET = 10,
            COMMAND_CODE = 11,
            EVENT_POINT_BUFF = 12,
            EVENT_BOARD_GAME_TOKEN = 13
        }
    }

    public class GuideEntity
    {
        public enum GuideType
        {
            COMBINE = 1,
            SHOP = 2,
            SVT_COSTUME = 3
        }
    }

    static public class Individuality
    {
        public enum TYPE
        {
            NONE = 0
        }
    }

    static public class MapCameraViewAdjusterUtil
    {
        public enum FailedReason
        {
            NONE = 0,
            HAS_INTERSECT = 1,
            OVERFLOW_CAMERA_RECT_UNAVOIDABLE = 2
        }
    }

    public class MapCondEntity
    {
        public enum ChangeType
        {
            BUTTON_DISPLAY = 1,
            CHANGE_MAP_IMAGE = 2,
            CHANGE_BGM = 3,
            HEADER_IMAGE = 4,
            ON_MAP_CAMERA_OFFSET_X = 5,
            ON_MAP_CAMERA_OFFSET_Y = 6
        }
    }

    public class MapEntity
    {
        public enum StartType
        {
            NONE = 1,
            SCRIPT = 2,
            QUEST = 4
        }
    }

    public class MapGimmickEntity
    {
        public enum GimmickType
        {
            NORMAL = 0,
            EVENT_MISSION = 1
        }
    }

    static public class MissionInfoMaker
    {
        public enum ProgStatus
        {
            LOCK = 0,
            NOSTART = 1,
            PROGRESS = 2,
            CLEAR = 3,
            ACHIVE = 4,
            END = 5
        }
    }

    static public class MissionType
    {
        public enum Type
        {
            NONE = 0,
            EVENT = 1,
            WEEKLY = 2,
            DAILY = 3,
            EXTRA = 4,
            LIMITED = 5,
            COMPLETE = 6,
            RANDOM = 7
        }
    }

    public class MyRoomAddEntity
    {
        public enum OverwriteType
        {
            BG_IMAGE = 1,
            BGM = 2,
            SERVANT_OVERLAY_OBJECT = 6,
            BG_IMAGE_MULTIPLE = 7,
            BACK_OBJECT = 8
        }
    }

    public class NewsEntity
    {
        public enum enType
        {
            HTML_BODY = 1,
            HTML_URL = 2,
            TEMPLATE = 3,
            DATA_ANY = 4
        }
    }

    static public class NGUIText
    {
        public enum Alignment
        {
            Automatic = 0,
            Left = 1,
            Center = 2,
            Right = 3,
            Justified = 4
        }

        public enum SymbolStyle
        {
            None = 0,
            Normal = 1,
            Colored = 2
        }
    }

    public class NpcFollowerEntity
    {
        public enum Flag
        {
            RECOMMENDED_ICON = 1,
            IS_MY_SVT_OR_NPC = 2,
            FIXED_NPC = 4
        }
    }

    public class NpcServantFollowerEntity
    {
        public enum FlagKind
        {
            HIDE_SUPPORT = 1,
            NOT_USED_TREASURE_DEVICE = 2,
            NO_DISPLAY_BONUS_ICON = 3,
            APPLY_SVT_CHANGE = 4,
            HIDE_EQUIP = 5,
            NO_DISPLAY_BONUS_ICON_EQUIP = 6,
            NPC = 0
        }

        public enum FlagField
        {
            HIDE_SUPPORT = 2,
            NOT_USED_TREASURE_DEVICE = 4,
            NO_DISPLAY_BONUS_ICON = 8,
            APPLY_SVT_CHANGE = 16,
            HIDE_EQUIP = 32,
            NO_DISPLAY_BONUS_ICON_EQUIP = 64,
            NPC = 1
        }
    }

    public class OtherUserGameEntity
    {
        public enum ReturnSupportServantType
        {
            MainQuest = 0,
            EventQuest = 1
        }
    }

    public class PartialMaintenanceEntity
    {
        public enum PartialMaintenanceType
        {
            STONE_GACHA = 1,
            CHALICE = 2
        }
    }

    public class QuestEntity
    {
        public enum enType
        {
            MAIN = 1,
            FREE = 2,
            FRIENDSHIP = 3,
            EVENT = 5,
            HEROBALLAD = 6,
            WAR_BOARD = 7
        }

        public enum TypeFlag
        {
            NONE = 0,
            MAIN = 2,
            FREE = 4,
            FRIENDSHIP = 8,
            EVENT = 32,
            HEROBALLAD = 64,
            WAR_BOARD = 128,
            ALL = 238
        }

        public enum enForceOperation
        {
            NONE = 0,
            FORCE_OPEN = 1,
            FORCE_CLOSE = 2
        }

        public enum enAfterClear
        {
            CLOSE = 1,
            REPEAT_FIRST = 2,
            REPEAT_LAST = 3,
            RESET_INTERVAL = 4,
            CLOSE_DISP = 5
        }

        public enum Flag : long
        {
            NONE = 1L,
            NO_BATTLE = 2L,
            RAID = 4L,
            RAID_CONNECTION = 8L,
            NO_CONTINUE = 16L,
            NO_DISPLAY_REMAIN = 32L,
            RAID_LAST_DAY = 64L,
            CLOSED_HIDE_COST_ITEM = 128L,
            CLOSED_HIDE_COST_NUM = 256L,
            CLOSED_HIDE_PROGRESS = 512L,
            CLOSED_HIDE_RECOMMEND_LV = 1024L,
            CLOSED_HIDE_TREND_CLASS = 2048L,
            CLOSED_HIDE_REWARD = 4096L,
            NO_DISPLAY_CONSUME = 8192L,
            SUPER_BOSS = 16384L,
            NO_DISPLAY_MISSION_NOTIFY = 32768L,
            HIDE_PROGRESS = 65536L,
            DROP_FIRST_TIME_ONLY = 131072L,
            CHAPTER_SUB_ID_JAPANESE_NUMERALS = 262144L,
            SUPPORT_ONLY_FORCE_BATTLE = 524288L,
            EVENT_DECK_NO_SUPPORT = 1048576L,
            FATIGUE_BATTLE = 2097152L,
            SUPPORT_SELECT_AFTER_SCRIPT = 4194304L,
            BRANCH = 8388608L,
            USER_EVENT_DECK = 16777216L,
            NO_DISPLAY_RAID_REMAIN = 33554432L,
            QUEST_MAX_DAMAGE_RECORD = 67108864L,
            ENABLE_FOLLOW_QUEST = 134217728L,
            SUPPORT_SVT_MULTIPLE_SET = 268435456L,
            SUPPORT_ONLY_BATTLE = 536870912L,
            ACT_CONSUME_BATTLE_WIN = 1073741824L,
            VOTE = 2147483648L,
            HIDE_MASTER = 4294967296L,
            DISABLE_MASTER_SKILL = 8589934592L,
            DISABLE_COMMAND_SPEEL = 17179869184L,
            SUPPORT_SVT_EDITABLE_POSITION = 34359738368L,
            BRANCH_SCENARIO = 68719476736L,
            QUEST_KNOCKDOWN_RECORD = 137438953472L,
            NOT_RETRIEVABLE = 274877906944L,
            DISPLAY_LOOPMARK = 549755813888L,
            BOOST_ITEM_CONSUME_BATTLE_WIN = 1099511627776L,
            PLAY_SCENARIO_WITH_MAPSCREEN = 2199023255552L,
            BATTLE_RETREAT_QUEST_CLEAR = 4398046511104L,
            BATTLE_RESULT_LOSE_QUEST_CLEAR = 8796093022208L,
            BRANCH_HAVING = 35184372088832L,
            NO_DISPLAY_NEXT_ICON = 70368744177664L,
            WINDOW_ONLY = 140737488355328L,
            CHANGE_MASTERS = 281474976710656L,
            NOT_DISPLAY_RESULT_GET_POINT = 562949953421312L,
            FORCE_TO_NO_DROP = 1125899906842624L,
            DISPLAY_CONSUME_ICON = 2251799813685248L,
            HARVEST = 4503599627370496L,
            RECONSTRUCTION = 9007199254740992L,
            ENEMY_IMMEDIATE_APPEAR = 18014398509481984L,
            NO_SUPPORT_LIST = 36028797018963968L,
            LIVE = 72057594037927936L,
            FORCE_DISPLAY_ENEMY_INFO = 144115188075855872L,
            ALLOUT_BATTLE = 288230376151711744L,
            RECOLLECTION = 576460752303423488L
        }

        public enum ConsumeType
        {
            NONE = 0,
            AP = 1,
            RP = 2,
            ITEM = 3,
            AP_AND_ITEM = 4
        }
    }

    static public class QuestGroupType
    {
        public enum Type
        {
            NONE = 0,
            EVENT_QUEST = 1,
            QUEST_RELEASE = 2,
            EVENT_POINT_QUEST = 3,
            EVENT_POINT_GROUP_QUEST = 4,
            EVENT_RACE_QUEST = 5,
            EVENT_RACE_GROUP_QUEST = 6,
            MISSION_GROUP_QUEST = 7,
            EVENT_TOWER = 8,
            EVENT_TOWER_FLOOR = 9,
            HIGHLIGHT_QUEST = 10,
            EVENT_DAILY_POINT = 11,
            EVENT_ACTIVITY_POINT_GAUGE = 12,
            INTERLUDE = 13,
            EVENT_BATTLE_LINE = 14,
            BATTLE_GROUP = 15,
            SHARE_QUEST_INFO = 16,
            ALLOUT_BATTLE_QUEST = 17
        }
    }

    public class QuestMessageEntity
    {
        public enum QuestMessageDisplayType
        {
            NONE = 0,
            DIALOG = 1,
            WINDOW_BEFORE = 2,
            WINDOW_AFTER = 3,
            MOVIE_DIALOG = 4,
            MOVIE_DELETE_DIALOG = 5,
            SCRIPT_BEFORE = 6
        }
    }

    public class QuestPhaseDetailAddEntity
    {
        public enum OverwriteType
        {
            AFTER_ACITON = 1,
            BEFORE_ACITON = 2
        }
    }

    public class QuestScriptEntity
    {
        public enum FolderType
        {
            NONE = 0,
            MATERIAL_FOLDER = 1,
            EVENT = 2,
            SVT = 3
        }
    }

    public class RecoverEntity
    {
        public enum RecoverTarget
        {
            AP = 1,
            RP = 2
        }
    }

    public class ServantAnimationOverwriteEntity
    {
        public enum PhaseType
        {
            NONE = 0,
            TACTICAL = 1,
            COMMAND = 2,
            BATTLE = 3
        }

        public enum ApplyType
        {
            NONE = 0,
            PLAYER = 1,
            ENEMY = 2,
            ALL = 3
        }
    }

    public class ServantChangeEntity
    {
        public enum FlagType
        {
            NONE = 1,
            NONE_EFFECT = 2,
            NONE_MATERIAL_SPLIT = 4,
            TRUE_NAME_IS_KNOWN = 8,
            NONE_BATTLE_VOICE_SELECT = 16
        }
    }

    public class ServantClassEntity
    {
        public enum SupportGroupType
        {
            ALL = 0,
            SABER = 1,
            ARCHER = 2,
            LANCER = 3,
            RIDER = 4,
            CASTER = 5,
            ASSASSIN = 6,
            BERSERKER = 7,
            EXTRA = 8,
            MIX = 9,
            NOT_SUPPORT = 999
        }
    }

    public class ServantCollectionEntity
    {
        public enum CollectionEffectType
        {
            INVALID = -1,
            NONE = 0,
            DATA_LOST = 1,
            HIDE = 2
        }
    }

    public class ServantEntity
    {
        public enum FlagKind
        {
            ONLY_USE_FOR_NPC = 1,
            SVT_EQUIP_FRIEND_SHIP = 2,
            IGNORE_COMBINE_LIMIT_SPECIAL = 3,
            SVT_EQUIP_EXP = 4,
            SVT_EQUIP_CHOCOLATE = 5
        }

        public enum FlagField
        {
            ONLY_USE_FOR_NPC = 2,
            SVT_EQUIP_FRIEND_SHIP = 4,
            IGNORE_COMBINE_LIMIT_SPECIAL = 8,
            SVT_EQUIP_EXP = 16,
            SVT_EQUIP_CHOCOLATE = 32
        }
    }

    public class ServantExceedEntity
    {
        public enum FRAMETYPE
        {
            BLACK = 0,
            BRONZE = 1,
            SILVER = 2,
            GOLD = 3,
            FRAME_0801 = 4,
            FRAME_0802 = 5,
            FRAME_0803 = 6,
            FRAME_0804 = 7
        }
    }

    public class ServantFlagEntity
    {
        public enum SvtScriptFlagType
        {
            SECRET_TREASURE_DEVICE_GET = 1
        }
    }

    static public class ServantLimitUpVoiceCache
    {
        public enum Type
        {
            NONE = 0,
            MATERIAL = 1,
            SERVANT_DETAIL = 2
        }
    }

    public class ServantScriptEntity
    {
        public enum OffsetKind
        {
            NORMAL = 0,
            MYROOM = 1,
            BATTLE = 2,
            EVENT_REWORD = 3,
            EVENT_SHOP = 4,
            MISSON = 5,
            TERMINAL = 6,
            BATTLE_BOND = 7
        }
    }

    public class ServantTreasureDvcEntity
    {
        public enum Flag
        {
            NONE = 1,
            WITH_PLAYER_PROGRESS = 2,
            NONE_TREASURE_DEVICE_EFFECT = 4,
            SECRET_TREASURE_DEVICE = 8,
            NOT_DISPLAY_SKILL_ICON = 16
        }
    }

    public class ShopDetailEntity
    {
        public enum FrequencyType
        {
            ONCE = 1,
            ONCE_UNTIL_REBOOT = 2,
            EVERY_TIME = 3,
            VALENTINE = 4,
            EVERY_TIME_AFTER = 5
        }
    }

    static public class ShopPlayVoiceConstants
    {
        public enum VoiceKind
        {
            ENTER_EVENT_SHOP = 1,
            ENTER_SELL_SERVANT = 2,
            ENTER_MANA_PRI_SHOP = 3,
            ENTER_RARE_PRI_SHOP = 4,
            ENTER_SVT_STORAGE_SHOP = 5,
            ENTER_EQUIP_STORAGE_SHOP = 6,
            ENTER_FRAGMENT_SHOP = 7,
            ENTER_BANK_ITEM = 8,
            ENTER_ANONYMOUS_SHOP = 9,
            ENTER_STONE_SHOP = 10,
            BACK_SHOP1 = 11,
            BACK_SHOP2 = 12,
            CANCEL_SHOP = 13,
            ENTER_SPECIAL_ITEM_SHOP = 14,
            ENTER_GRAIL_FRAGMENTS_SHOP = 15,
            ENTER_SVT_COSTUME_SHOP = 16,
            ENTER_START_UP_SUMMON_SHOP = 17,
            ENTER_SHOP13_SHOP = 18,
            ENTER_TRADE_AP_SHOP = 19
        }

        public enum VoiceFlag
        {
            ENTER_EVENT_SHOP = 2,
            ENTER_SELL_SERVANT = 4,
            ENTER_MANA_PRI_SHOP = 8,
            ENTER_RARE_PRI_SHOP = 16,
            ENTER_SVT_STORAGE_SHOP = 32,
            ENTER_EQUIP_STORAGE_SHOP = 64,
            ENTER_FRAGMENT_SHOP = 128,
            ENTER_BANK_ITEM = 256,
            ENTER_ANONYMOUS_SHOP = 512,
            ENTER_STONE_SHOP = 1024,
            BACK_SHOP1 = 2048,
            BACK_SHOP2 = 4096,
            CANCEL_SHOP = 8192,
            ENTER_SPECIAL_ITEM_SHOP = 16384,
            ENTER_GRAIL_FRAGMENTS_SHOP = 32768,
            ENTER_SVT_COSTUME_SHOP = 65536,
            ENTER_START_UP_SUMMON_SHOP = 131072,
            ENTER_SHOP13_SHOP = 262144,
            ENTER_TRADE_AP_SHOP = 524288
        }
    }

    static public class ShopRootConstants
    {
        public enum State
        {
            INIT = 0,
            TOP = 1,
            MANA_PRI = 2,
            RARE_PRI = 3,
            STONE_FRAGMENTS = 4,
            SPECIAL = 5,
            ANONYMOUS = 6,
            EVENT = 7,
            EVENT_ITEM = 8,
            SELL_SERVANT = 9,
            BANK = 10,
            SERVANT_STORAGE = 11,
            EQUIP_STORAGE = 12,
            HELP = 13,
            GRAIL_FRAGMENTS = 14,
            SVT_COSTUME = 15,
            START_UP_SUMMON = 16,
            COIN_ROOM = 17,
            SHOP13 = 18,
            TRADE_AP = 19
        }

        public enum InputState
        {
            INIT_START = 0,
            INIT_END = 1,
            INPUT = 2,
            QUIT_START = 3,
            QUIT_END = 4
        }
    }

    public class SkillEntity
    {
        public enum CutinCameraSide
        {
            ENEMY_ALL = 0,
            PLAYER_ALL = 1,
            FIELD_ALL = 2
        }
    }

    public class SpotAddEntity
    {
        public enum SpotOverwriteType
        {
            NONE = 0,
            FLAG = 1,
            PATH_POINT_RATIO = 2,
            PATH_POINT_RATIO_LIMIT = 3,
            NAME_PANEL_OFFSET_X = 4,
            NAME_PANEL_OFFSET_Y = 5
        }
    }

    public class SpotEntity
    {
        public enum enSpotCondType
        {
            NONE = 1,
            QUEST_CLEAR = 2,
            NOT_QUEST_CLEAR = 3,
            INVALID = 4,
            MISSION_ACHIEVE = 5,
            QUEST_RELEASED = 6,
            NOT_QUEST_GROUP_CLEAR = 7,
            QUEST_GROUP_CLEAR = 8,
            ITEM_GET = 9,
            QUEST_CLEAR_RAW = 10,
            QUEST_GROUP_CLEAR_RAW = 11,
            EVENT_GROUP_POINT_RATIO_IN_TERM = 12,
            EVENT_RACE_SCRIPT_PLAYED = 13,
            QUEST_CLEAR_PHASE = 14,
            NOT_QUEST_CLEAR_PHASE = 15,
            NOT_MISSION_ACHIEVE = 16,
            QUEST_AVAILABLE = 17,
            EVENT_GROUP_POINT = 18,
            EVENT_GROUP_POINT_BELOW = 19,
            EVENT_TOTAL_POINT = 20,
            EVENT_TOTAL_POINT_BELOW = 21,
            EVENT_VALUE = 22,
            EVENT_VALUE_BELOW = 23,
            EVENT_FLAG = 24,
            EVENT_STATUS = 25,
            NOT_EVENT_STATUS = 26,
            MISSION_CLEAR = 27,
            NOT_MISSION_CLEAR = 28,
            MISSION_CLEAR_ONLY = 29,
            MULTIPLE_DATE = 30,
            COMMON_RELEASE = 31
        }

        public enum FlagKind
        {
            NONE = 0,
            NOT_DISPLAY = 1,
            MOVE_SPOT = 2,
            HIDE_NAME = 3,
            INACTIVE_DISPLAY_NAME = 4,
            SORTED_BY_RELEASE_QUEST = 5,
            FOLDER_SPOT_HIDDEN = 6
        }

        public enum Flag
        {
            NONE = 1,
            NOT_DISPLAY = 2,
            MOVE_SPOT = 4,
            HIDE_NAME = 8,
            INACTIVE_DISPLAY_NAME = 16,
            SORTED_BY_RELEASE_QUEST = 32,
            FOLDER_SPOT_HIDDEN = 64
        }
    }

    public class SpotPathEntity
    {
        public enum ValueType
        {
            NONE = 0,
            EVENT_RACE = 1,
            EVENT_TIME_LIMIT_RAID = 2
        }
    }

    public class StageEntity
    {
        public enum FadeType
        {
            SlideIn = 0,
            AlphaFadeIn = 1,
            FadeOff = 2
        }
    }

    static public class SvtType
    {
        public enum Type
        {
            NORMAL = 1,
            HEROINE = 2,
            COMBINE_MATERIAL = 3,
            ENEMY = 4,
            ENEMY_COLLECTION = 5,
            SERVANT_EQUIP = 6,
            STATUS_UP = 7,
            SVT_EQUIP_MATERIAL = 8,
            ENEMY_COLLECTION_DETAIL = 9,
            ALL = 10,
            COMMAND_CODE = 11,
            SVT_MATERIAL_TD = 12
        }
    }

    public class TblFriendEntity
    {
        public enum Flag
        {
            NONE = 1,
            FRIEND_ID_MES_HIDE = 2,
            USER_ID_MES_HIDE = 4,
            TO_FRIENDID_LOCK = 8,
            TO_USERID_LOCK = 16
        }
    }

    static public class TerminalPramsManager
    {
        public enum enSceneStatus
        {
            enNone = 0,
            enInitialize = 1,
            enResume = 2,
            enResumeFromScript = 3,
            enMAX = 4
        }

        public enum eDispState
        {
            None = 0,
            Top = 1,
            Map = 2,
            Caldea = 3,
            Story = 4,
            Hero = 5,
            MAX = 6
        }

        public enum eSpecifiedScene
        {
            None = 0,
            EventReward = 1
        }
    }

    public class TreasureDvcEntity
    {
        public enum EffectFlagKind
        {
            SUPPORT = -1,
            ATTACK_ENEMY_ALL = 0,
            ATTACK_ENEMY_ONE = 1
        }

        public enum EffectFlag : long
        {
            SUPPORT = -1L,
            ATTACK_ENEMY_ALL = 1L,
            ATTACK_ENEMY_ONE = 2L
        }
    }

    public class UserCommandCodeEntity
    {
        public enum StatusKind
        {
            LOCK = 0,
            CHOICE = 4
        }

        public enum StatusFlag
        {
            LOCK = 1,
            CHOICE = 16
        }
    }

    public class UserEventRandomMissionEntity
    {
        public enum Status
        {
            NONE = 0,
            START = 1
        }
    }

    public class UserFollowEntity
    {
        public enum Flag
        {
            NONE = 1,
            IS_LOCK = 2
        }
    }

    public class UserGachaEntity
    {
        public enum StatusKind
        {
            PC_END = 1
        }

        public enum Status
        {
            PC_END = 2
        }
    }

    public class UserQuestEntity
    {
        public enum StatusKind
        {
            RESET = 1,
            RESET_REWARD = 2,
            PURCHASED_RARE_PRI = 3,
            CHALLENGED_NEWEST_PHASE = 4,
            BATTLE_RESULT_WIN = 5,
            BATTLE_RESULT_LOSE = 6,
            LATEST_RESULT_WIN = 7,
            LATEST_RESULT_LOSE = 8
        }

        public enum StatusFlag
        {
            RESET = 2,
            RESET_REWARD = 4,
            PURCHASED_RARE_PRI = 8,
            CHALLENGED_NEWEST_PHASE = 16,
            BATTLE_RESULT_WIN = 32,
            BATTLE_RESULT_LOSE = 64,
            LATEST_RESULT_WIN = 128,
            LATEST_RESULT_LOSE = 256
        }
    }

    public class UserQuestRecordEntity
    {
        public enum QuestRecordType
        {
            QUEST_MAX_DAMAGE = 1,
            QUEST_KNOCKDOWN = 2
        }
    }

    public class UserServantCollectionEntity
    {
        public enum SVT_COMMON_KIND
        {
            ENABLE_TD_SPEED = 1,
            TD_SPEED = 2
        }

        public enum SVT_COMMON_FLAG
        {
            ENABLE_TD_SPEED = 2,
            TD_SPEED = 4
        }
    }

    public class UserServantEntity
    {
        public enum StatusKind
        {
            LOCK = 0,
            EVENT_JOIN = 1,
            WITHDRAWAL = 2,
            APRIL_FOOL_CANCEL = 3,
            CHOICE = 4,
            NO_PERIOD = 5,
            COND_JOIN = 6,
            ADD_FRIENDSHIP_HEROINE = 7
        }

        public enum StatusFlag
        {
            LOCK = 1,
            EVENT_JOIN = 2,
            WITHDRAWAL = 4,
            APRIL_FOOL_CANCEL = 8,
            CHOICE = 16,
            NO_PERIOD = 32,
            COND_JOIN = 64,
            ADD_FRIENDSHIP_HEROINE = 128
        }

        public enum RandomLimitCountKind
        {
            IMAGE_LIMIT_COUNT = 0,
            DISP_LIMIT_COUNT = 1,
            COMMANDCARD_LIMIT_COUNT = 2,
            ICON_LIMIT_COUNT = 3,
            PORTRAIT_LIMIT_COUNT = 4
        }
    }

    public class VoiceEntity
    {
        public enum Flag
        {
            MATERIAL_OPEN = 2
        }
    }

    public class WarAddEntity
    {
        public enum WarOverwriteType
        {
            BGM = 1,
            PARENT_WAR = 2,
            BANNER = 3,
            BG_IMAGE = 4,
            SVT_IMAGE = 5,
            FLAG = 6,
            BASE_MAP_ID = 7,
            NAME = 8,
            LONG_NAME = 9,
            MATERIAL_PARENT_WAR = 10,
            COORDINATES = 11,
            EFFECT_CHANGE_BLACK_MARK = 12,
            QUEST_BOARD_SECTION_IMAGE = 13,
            WAR_FORCE_DISP = 14,
            WAR_FORCE_HIDE = 15,
            START_TYPE = 16,
            NOTICE_DIALOG_TEXT = 17,
            CLEAR_MARK = 18,
            EFFECT_CHANGE_WHITE_MARK = 19
        }
    }

    public class WarBoardActionTrendConditionEntity
    {
        public enum ConditionType
        {
            ATTACK_RANGE = 1,
            NOT_ATTACK_RANGE = 2,
            MOVE_BY_ATTACK_RANGE = 3,
            NOT_MOVE_BY_ATTACK_RANGE = 4,
            REPLACE = 5,
            NOT_REPLACE = 6,
            DEFENSE_AREA_ON_ENEMY = 7,
            NOT_DEFENSE_AREA_ENEMY = 8,
            MOVE_BY_DEFENSE_AREA_ON_ENEMY = 9,
            NOT_MOVE_BY_DEFENSE_AREA_ON_ENEMY = 10,
            DEFENSE_AREA_ON_MY_SERVANT = 11,
            NOT_DEFENSE_AREA_ON_MY_SERVANT = 12,
            MOVE_BY_DEFENSE_AREA_ON_MY_SERVANT = 13,
            NOT_MOVE_BY_DEFENSE_AREA_ON_MY_SERVANT = 14,
            BENEFIT_RANGE = 15,
            NOT_BENEFIT_RANGE = 16,
            MOVE_BY_BENEFIT_RANGE = 17,
            NOT_MOVE_BY_BENEFIT_RANGE = 18,
            EXIST_CLASS_ADVANTAGE_SERVANT = 19,
            NOT_EXIST_CLASS_ADVANTAGE_SERVANT = 20,
            EXIST_CLASS_DIS_ADVANTAGE_SERVANT = 21,
            NOT_EXIST_CLASS_DIS_ADVANTAGE_SERVANT = 22,
            EXIST_DESIGNATION_ITEM = 23,
            NOT_EXIST_DESIGNATION_ITEM = 24,
            MOVE_BY_MASTER_AND_ENEMY_RANGE_APPROACH = 25,
            MOVE_BY_MASTER_AND_ENEMY_RANGE_LEAVE = 26,
            MOVE_BY_MASTER_AND_ENEMY_RANGE_NO_CHANGE = 27,
            MOVE_BY_MY_SERVANT_AND_ENEMY_RANGE_APPROACH = 28,
            MOVE_BY_MY_SERVANT_AND_ENEMY_RANGE_LEAVE = 29,
            MOVE_BY_MY_SERVANT_AND_ENEMY_RANGE_NO_CHANGE = 30,
            MOVE_BY_MY_SERVANT_AND_MASTER_RANGE_APPROACH = 31,
            MOVE_BY_MY_SERVANT_AND_MASTER_RANGE_LEAVE = 32,
            MOVE_BY_MY_SERVANT_AND_MASTER_RANGE_NO_CHANGE = 33,
            MOVE_BY_SERVANT_AND_CLASS_ADVANTAGE_SERVANT_RANGE_APPROACH = 34,
            MOVE_BY_SERVANT_AND_CLASS_ADVANTAGE_SERVANT_RANGE_LEAVE = 35,
            MOVE_BY_SERVANT_AND_CLASS_ADVANTAGE_SERVANT_RANGE_NO_CHANGE = 36,
            MOVE_BY_SERVANT_AND_CLASS_DIS_ADVANTAGE_SERVANT_RANGE_APPROACH = 37,
            MOVE_BY_SERVANT_AND_CLASS_DIS_ADVANTAGE_SERVANT_RANGE_LEAVE = 38,
            MOVE_BY_SERVANT_AND_CLASS_DIS_ADVANTAGE_SERVANT_RANGE_NO_CHANGE = 39,
            MOVE_BY_SERVANT_AND_DESIGNATION_ITEM_RANGE_APPROACH = 40,
            MOVE_BY_SERVANT_AND_DESIGNATION_ITEM_RANGE_LEAVE = 41,
            MOVE_BY_SERVANT_AND_DESIGNATION_ITEM_RANGE_NO_CHANGE = 42,
            EXIST_ATTACK_ADVANTAGE_SERVANT = 43,
            NOT_EXIST_ATTACK_ADVANTAGE_SERVANT = 44,
            EXIST_ATTACK_DIS_ADVANTAGE_SERVANT = 45,
            NOT_EXIST_ATTACK_DIS_ADVANTAGE_SERVANT = 46,
            EXIST_DEFENSE_ADVANTAGE_SERVANT = 47,
            NOT_EXIST_DEFENSE_ADVANTAGE_SERVANT = 48,
            EXIST_DEFENSE_DIS_ADVANTAGE_SERVANT = 49,
            NOT_EXIST_DEFENSE_DIS_ADVANTAGE_SERVANT = 50,
            MOVE_BY_SERVANT_AND_ATTACK_ADVANTAGE_SERVANT_RANGE_APPROACH = 51,
            MOVE_BY_SERVANT_AND_ATTACK_ADVANTAGE_SERVANT_RANGE_LEAVE = 52,
            MOVE_BY_SERVANT_AND_ATTACK_ADVANTAGE_SERVANT_RANGE_NO_CHANGE = 53,
            MOVE_BY_SERVANT_AND_ATTACK_DIS_ADVANTAGE_SERVANT_RANGE_APPROACH = 54,
            MOVE_BY_SERVANT_AND_ATTACK_DIS_ADVANTAGE_SERVANT_RANGE_LEAVE = 55,
            MOVE_BY_SERVANT_AND_ATTACK_DIS_ADVANTAGE_SERVANT_RANGE_NO_CHANGE = 56,
            MOVE_BY_SERVANT_AND_DEFENSE_ADVANTAGE_SERVANT_RANGE_APPROACH = 57,
            MOVE_BY_SERVANT_AND_DEFENSE_ADVANTAGE_SERVANT_RANGE_LEAVE = 58,
            MOVE_BY_SERVANT_AND_DEFENSE_ADVANTAGE_SERVANT_RANGE_NO_CHANGE = 59,
            MOVE_BY_SERVANT_AND_DEFENSE_DIS_ADVANTAGE_SERVANT_RANGE_APPROACH = 60,
            MOVE_BY_SERVANT_AND_DEFENSE_DIS_ADVANTAGE_SERVANT_RANGE_LEAVE = 61,
            MOVE_BY_SERVANT_AND_DEFENSE_DIS_ADVANTAGE_SERVANT_RANGE_NO_CHANGE = 62,
            MOVE_BY_ATTACK_RQANGE_ENEMY_MASTER = 63,
            NOT_MOVE_BY_ATTACK_RQANGE_ENEMY_MASTER = 64,
            MOVE_BY_ENEMY_MASTER_RANGE_APPROACH = 65,
            MOVE_BY_ENEMY_MASTER_RANGE_LEAVE = 66,
            MOVE_BY_ENEMY_MASTER_RANGE_NO_CHANGE = 67,
            ATTACK_MASTER = 68,
            NOT_ATTACK_MASTER = 69,
            ACTION_TYPE = 70,
            ACTION_COUNT_ON_THIS_TURN = 71,
            ACTION_COUNT_ON_THIS_TURN_OVER = 72,
            ACTION_COUNT_ON_THIS_TURN_UNDER = 73,
            EXIST_TARGET = 74,
            NOT_EXIST_TARGET = 75,
            IS_TARGET_ENEMY = 76,
            IS_NOT_TARGET_ENEMY = 77,
            AROUND_TARGET = 78,
            NOR_AROUND_TARGET = 79,
            MOVE_BY_TARGET_RANGE_APPROACH = 80,
            MOVE_BY_TARGET_RANGE_LEAVE = 81,
            MOVE_BY_TARGET_RANGE_NO_CHANGE = 82,
            DETOUR_TARGET_ROUTE = 83,
            NOT_DETOUR_TARGET_ROUTE = 84,
            MOVE_BY_USE_DRTOUR_TARGET_RANGE_APPROACH = 85,
            MOVE_BY_USE_DRTOUR_TARGET_RANGE_LEAVE = 86,
            MOVE_BY_USE_DRTOUR_TARGET_RANGE_NO_CHANGE = 87,
            ALLY_BLOCK_SHORTEST_ROUTE_ENEMY_AND_MASTER = 88,
            NOT_ALLY_BLOCK_SHORTEST_ROUTE_ENEMY_AND_MASTER = 89,
            MOBE_BY_ALLY_BLOCK_SHORTEST_ROUTE_ENEMY_AND_MASTER = 90,
            MOBE_BY_NOT_ALLY_BLOCK_SHORTEST_ROUTE_ENEMY_AND_MASTER = 91,
            ON_SHORTEST_ROUTE_ENEMY_AND_MASTER = 92,
            NOT_ON_SHORTEST_ROUTE_ENEMY_AND_MASTER = 93,
            MOVE_BY_ON_SHORTEST_ROUTE_ENEMY_AND_MASTER = 94,
            MOVE_BY_NOT_ON_SHORTEST_ROUTE_ENEMY_AND_MASTER = 95,
            ENEMY_IN_SHORTEST_ROUTE_TARGET = 96,
            NOT_ENEMY_IN_SHORTEST_ROUTE_TARGET = 97,
            EXIST_ENEMY_IN_RANGE_UNDER = 98,
            NOT_EXIST_ENEMY_IN_RANGE_UNDER = 99,
            ATTACK_COUNT_ON_THIS_TURN = 100,
            ATTACK_COUNT_ON_THIS_TURN_OVER = 101,
            ATTACK_COUNT_ON_THIS_TURN_UNDER = 102,
            AROUND_ALLY_MASTER = 103,
            NOT_AROUND_ALLY_MASTER = 104,
            AROUND_ALLY_SERVANT = 105,
            NOT_AROUND_ALLY_SERVANT = 106,
            MOVE_BY_MASTER_ENEMY_SHORTEST_ROUTE_WITHIN_ALLY_SERVANT = 107,
            NOT_MOVE_BY_MASTER_ENEMY_SHORTEST_ROUTE_WITHIN_ALLY_SERVANT = 108,
            DEFENSE_AREA_WITHIN_ENEMY_ALL_BLOCK = 109,
            NOT_DEFENSE_AREA_WITHIN_ENEMY_ALL_BLOCK = 110,
            IS_TARGET_ALLY = 111,
            IS_NOT_TARGET_ALLY = 112,
            MOVE_BY_ON_DETOUR_ROUTE = 113,
            MOVE_BY_NOT_ON_DETOUR_ROUTE = 114,
            ACTION_TYPE_ADVANCE = 115,
            ACTION_TYPE_MIDDLE = 116,
            ACTION_TYPE_REAR = 117,
            IS_ALL_DEFENSE_AREA_ENEMY_ROUTE_BLOCK = 118,
            IS_NOT_ALL_DEFENSE_AREA_ENEMY_ROUTE_BLOCK = 119,
            IS_COME_BACK_SQUARE = 120,
            IS_NOT_COME_BACK_SQUARE = 121,
            MOVE_BY_USE_DRTOUR_TARGET_RANGE_APPROACH_DRTOUR = 122,
            MOVE_BY_USE_DRTOUR_TARGET_RANGE_LEAVE_DRTOUR = 123,
            MOVE_BY_USE_DRTOUR_TARGET_RANGE_NO_CHANGE_DRTOUR = 124,
            IS_MOVE_BY_ALL_DEFENSE_AREA_ENEMY_ROUTE_BLOCK = 125,
            IS_NOT_MOVE_BY_ALL_DEFENSE_AREA_ENEMY_ROUTE_BLOCK = 126
        }
    }

    public class WarBoardActionTrendEntity
    {
        public enum ActionType
        {
            ATTACK = 1,
            MASTER_DEFENSE = 2
        }
    }

    public class WarBoardDataEntity
    {
        public enum ProgressType
        {
            NORMAL = 1,
            BATTLE = 2,
            PREPARE = 3
        }
    }

    public class WarBoardOnboardSkillEntity
    {
        public enum SkillTiming
        {
            BATTLE_START = 0,
            PLAYER_TURN = 1,
            ENEMY_TURN = 2
        }

        public enum SkillEffect
        {
            NONE = 0,
            BUFF = 1,
            DEBUFF = 2
        }
    }

    public class WarBoardPartySkillEntity
    {
        public enum TargetType
        {
            Both = 0,
            Player = 1,
            Enemy = 2
        }
    }

    public class WarBoardRatingBaseEntity
    {
        public enum Type
        {
            ALLY_SERVANT_SHORTEST_DISTANCE = 0,
            ENEMY_SERVANT_SHORTEST_DISTANCE = 1,
            ALLY_MASTER_SHORTEST_DISTANCE = 2,
            ENEMY_MASTER_SHORTEST_DISTANCE = 3,
            ITEM_SHORTEST_DISTANCE = 4,
            PRIORITY_SPACE_SHORTEST_DISTANCE = 5
        }

        public enum Viewpoint
        {
            WARSITUATION = 0,
            BENEFIT = 1
        }
    }

    public class WarBoardRatingOffsetEntity
    {
        public enum Type
        {
            BASE_POINT = 0,
            ATTACK_MULTIPLE_ENEMY_WITH_BATTLE = 1,
            ATTACK_MULTIPLE_ALLY_WITH_BATTLE = 2,
            REPLACE = 3,
            NO_REPLACE = 4,
            ATTACK_TARGET_SERVANT_BREAK_POINT_UNDER_OVER = 5,
            ATTACK_TARGET_SERVANT_BREAK_POINT_LESSTHAN_OVER = 6,
            ATTACK_TARGET_MASTER = 7,
            NO_ATTACK_TARGET_MASTER = 8,
            ATTACK_TARGET_SERVANT_ATTACK_DEFENSE_ADVANTAGE = 9,
            ATTACK_TARGET_SERVANT_NOT_ATTACK_DEFENSE_ADVANTAGE_ATTACK_ADVANTAGE = 10,
            ATTACK_TARGET_SERVANT_NOT_ATTACK_DEFENSE_ADVANTAGE_NOT_ATTACK_ADVANTAGE_DEFENSE_DISADVANTAGE = 11,
            ATTACK_TARGET_SERVANT_ADVANTAGE_OTHER = 12,
            ACTION_PIECE_BREAK_POINT_UNDER_OVER = 13,
            ACTION_PIECE_BREAK_POINT_LESSTHAN_OVER = 14,
            ACTION_PIECE_NP_OVER = 15,
            NO_ACTION_PIECE_NP_OVER = 16,
            MOVE_AROUND_ENEMY_SERVANT_NONE = 17,
            MOVE_AROUND_ENEMY_SERVANT_EXIST = 18,
            MOVE_AROUND_ENEMY_SERVANT_OVER = 19,
            MOVE_AROUND_ALLY_SERVANT_NONE = 20,
            MOVE_AROUND_ALLY_SERVANT_EXIST = 21,
            MOVE_AROUND_ALLY_SERVANT_OVER = 22,
            MOVE_AROUND_ALLY_SERVANT_RANGE = 23,
            MOVE_AROUND_ALLY_SERVANT_RANGE_OVER = 24,
            MOVE_GET_DESIGNATION_ITEM = 25,
            NO_MOVE_GET_DESIGNATION_ITEM = 26,
            MOVE_AROUND_ALLY_SERVANT_RANGE_UNDER = 27,
            MOVE_AROUND_ALLY_SERVANT_RANGE_OVER_UNDER = 28,
            REPLACE_BETWEEN_SERVANT = 29,
            NO_REPLACE_BETWEEN_SERVANT = 30,
            MOVE_AROUND_ITEM = 31,
            MOVE_ON_ITEM = 32,
            MOVE_ON_EFFECT = 33
        }

        public enum Category
        {
            ATTACK = 0,
            MOVE = 1
        }
    }

    public class WarBoardStageLayoutEntity
    {
        public enum Type
        {
            NORMAL = 1,
            ITEM = 2,
            EFFECT = 3,
            TREASURE = 4
        }

        public enum ActionType
        {
            ADVANCE = 1,
            MIDDLE = 2,
            REAR = 3
        }
    }

    public class WarBoardStagePieceDetailEntity
    {
        public enum Flag
        {
            NOT_INCLUDE_WIN = 1
        }
    }

    public class WarBoardTacticalTrendEntity
    {
        public enum Type
        {
            EVAL_VALUE = 0,
            ATTACK = 1,
            WARSITUATION = 2,
            BENEFIT = 3,
            MASTER_ATTACK = 4,
            MASTER_DEFENSE = 5
        }
    }

    public class WarEntity
    {
        public enum Flag
        {
            WITH_MAP = 2,
            SHOW_ON_MATERIAL = 4,
            FOLDER_SORT_PRIOR = 8,
            STORY_SHORTCUT = 16,
            IS_EVENT = 32,
            CLOSE_AFTER_CLEAR = 64,
            MAIN_SCENARIO = 128,
            IS_WAR_ICON_LEFT = 256,
            CLEARED_RETURN_TO_TITLE = 512,
            NO_CLEAR_MARK_WITH_CLEAR = 1024,
            NO_CLEAR_MARK_WITH_COMPLETE = 2048,
            NOT_ENTRY_BANNER_ACTIVE = 4096,
            SHOP = 8192,
            BLACK_MARK_WITH_CLEAR = 16384,
            DISP_FIRST_QUEST = 32768,
            EFFECT_DISAPPEAR_BANNER = 65536,
            WHITE_MARK_WITH_CLEAR = 131072,
            WHITE_MARK_UNDER_BOARD = 262144,
            SUB_FOLDER = 524288,
            DISP_EARTH_POINT_WITHOUT_MAP = 1048576
        }

        public enum StartType
        {
            NONE = 0,
            SCRIPT = 1,
            QUEST = 2
        }
    }
}
