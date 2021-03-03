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
            PT_BACK_DEAD_EQUAL = 149
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
            USENP_TARGET = -11
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
            TURN_ENEMY_END = 6
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
            RESURRECTION = 42
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
            ATTACK_BEFORE_FUNCTION = 160
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
            FUNCTION_ATTACK_BEFORE = 98
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
            GET_REWARD_GIFT = 117,
            SEND_SUPPORT_FRIEND_POINT = 118,
            MOVE_POSITION = 119,
            REVIVAL = 120,
            DAMAGE_NP_INDIVIDUAL_SUM = 121,
            DAMAGE_VALUE_SAFE = 122,
            MOVE_STATE = 124
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
            COMPLETE = 6
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
            SHARE_QUEST_INFO = 16
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
            ENTER_GRAIL_FRAGMENTS_SHOP = 15
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
            ENTER_GRAIL_FRAGMENTS_SHOP = 32768
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
            GRAIL_FRAGMENTS = 14
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
            COMMAND_CODE = 11
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
}
