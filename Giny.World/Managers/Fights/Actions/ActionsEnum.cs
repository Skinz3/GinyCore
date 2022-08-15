﻿using Giny.Core.DesignPattern;

namespace Giny.World.Managers.Actions
{
    [WIP("replace old actions by the new one.")]
    public enum ActionsEnum
    {
        ACTION_CHARACTER_CHANGE_MAP = 2,

        ACTION_CHARACTER_CHANGE_RESPAWN_MAP = 3,

        ACTION_CHARACTER_TELEPORT_ON_SAME_MAP = 4,

        ACTION_CHARACTER_PUSH = 5,

        ACTION_CHARACTER_PULL = 6,

        ACTION_CHARACTER_DIVORCE_WIFE_OR_HUSBAND = 7,

        ACTION_CHARACTER_EXCHANGE_PLACES = 8,

        ACTION_CHARACTER_DODGE_HIT = 9,

        ACTION_CHARACTER_LEARN_EMOTICON = 10,

        ACTION_CHARACTER_CREATE_GUILD = 12,

        ACTION_QUEST_OBJECTIVE_VALIDATE = 30,

        ACTION_QUEST_STEP_VALIDATE = 31,

        ACTION_QUEST_QUEST_VALIDATE = 32,

        ACTION_QUEST_START = 34,

        ACTION_QUEST_RESET = 36,

        ACTION_QUEST_FORCE_START = 37,

        ACTION_BREACH_CREATE = 46,

        ACTION_BREACH_ENTER = 47,

        ACTION_BREACH_NEXT_FIGHT_ROOM = 48,

        ACTION_BREACH_NEXT_SAFE_ROOM = 49,

        ACTION_CARRY_CHARACTER = 50,

        ACTION_THROW_CARRIED_CHARACTER = 51,

        ACTION_BREACH_PREVIOUS_ROOM = 52,

        ACTION_BREACH_JUMP_TO_SAFE_ROOM = 53,

        ACTION_BREACH_KICK_OUT = 54,

        ACTION_BREACH_MODIFY_MAP = 55,

        ACTION_BREACH_DISPLAY_ROOMS_REWARDS = 56,

        ACTION_BREACH_GAIN_BONUS = 57,

        ACTION_BREACH_MODIFY_ROOM = 58,

        ACTION_BREACH_REMOVE_EROSION = 59,

        ACTION_BREACH_MODIFY_FIGHT_MODIFIER = 60,

        ACTION_BREACH_MODIFY_BOSS = 61,

        ACTION_BREACH_ADD_BOSS = 62,

        ACTION_ANOMALY_EXIT = 63,

        ACTION_CHARACTER_MOVEMENT_POINTS_STEAL = 77,

        ACTION_CHARACTER_MOVEMENT_POINTS_WIN = 78,

        ACTION_CHARACTER_MULTIPLY_RECEIVED_DAMAGE_OR_GIVE_LIFE_WITH_RATIO = 79,

        ACTION_CHARACTER_LIFE_POINTS_LOST_FROM_PUSH = 80,

        ACTION_CHARACTER_LIFE_POINTS_WIN_WITHOUT_ELEMENT = 81,

        ACTION_CHARACTER_LIFE_POINTS_STEAL_WITHOUT_BOOST = 82,

        ACTION_CHARACTER_ACTION_POINTS_STEAL = 84,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_FROM_WATER = 85,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_FROM_EARTH = 86,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_FROM_AIR = 87,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_FROM_FIRE = 88,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE = 89,

        ACTION_CHARACTER_DISPATCH_LIFE_POINTS_PERCENT = 90,

        ACTION_CHARACTER_LIFE_POINTS_STEAL_FROM_WATER = 91,

        ACTION_CHARACTER_LIFE_POINTS_STEAL_FROM_EARTH = 92,

        ACTION_CHARACTER_LIFE_POINTS_STEAL_FROM_AIR = 93,

        ACTION_CHARACTER_LIFE_POINTS_STEAL_FROM_FIRE = 94,

        ACTION_CHARACTER_LIFE_POINTS_STEAL = 95,

        ACTION_CHARACTER_LIFE_POINTS_LOST_FROM_WATER = 96,

        ACTION_CHARACTER_LIFE_POINTS_LOST_FROM_EARTH = 97,

        ACTION_CHARACTER_LIFE_POINTS_LOST_FROM_AIR = 98,

        ACTION_CHARACTER_LIFE_POINTS_LOST_FROM_FIRE = 99,

        ACTION_CHARACTER_LIFE_POINTS_LOST = 100,

        ACTION_CHARACTER_ACTION_POINTS_LOST = 101,

        ACTION_CHARACTER_LIFE_LOST_MODERATOR = 105,

        ACTION_CHARACTER_SPELL_REFLECTOR = 106,

        ACTION_CHARACTER_LIFE_LOST_REFLECTOR = 107,

        ACTION_CHARACTER_LIFE_POINTS_WIN = 108,

        ACTION_CHARACTER_LIFE_POINTS_LOST_CASTER = 109,

        ACTION_CHARACTER_BOOST_LIFE_POINTS = 110,

        ACTION_CHARACTER_BOOST_ACTION_POINTS = 111,

        ACTION_CHARACTER_BOOST_DAMAGES = 112,

        ACTION_CHARACTER_MULTIPLY_DAMAGES = 114,

        ACTION_CHARACTER_BOOST_CRITICAL_HIT = 115,

        ACTION_CHARACTER_DEBOOST_RANGE = 116,

        ACTION_CHARACTER_BOOST_RANGE = 117,

        ACTION_CHARACTER_BOOST_STRENGTH = 118,

        ACTION_CHARACTER_BOOST_AGILITY = 119,

        ACTION_CHARACTER_ACTION_POINTS_WIN = 120,

        ACTION_CHARACTER_BOOST_DAMAGES_FOR_ALL_GAME = 121,

        ACTION_CHARACTER_BOOST_CRITICAL_MISS = 122,

        ACTION_CHARACTER_BOOST_CHANCE = 123,

        ACTION_CHARACTER_BOOST_WISDOM = 124,

        ACTION_CHARACTER_BOOST_VITALITY = 125,

        ACTION_CHARACTER_BOOST_INTELLIGENCE = 126,

        ACTION_CHARACTER_MOVEMENT_POINTS_LOST = 127,

        ACTION_CHARACTER_BOOST_MOVEMENT_POINTS = 128,

        ACTION_CHARACTER_STEAL_GOLD = 130,

        ACTION_CHARACTER_REMOVE_ALL_EFFECTS = 132,

        ACTION_CHARACTER_ACTION_POINTS_LOST_CASTER = 133,

        ACTION_CHARACTER_MOVEMENT_POINTS_LOST_CASTER = 134,

        ACTION_CHARACTER_DEBOOST_RANGE_CASTER = 135,

        ACTION_CHARACTER_BOOST_RANGE_CASTER = 136,

        ACTION_CHARACTER_BOOST_DAMAGES_CASTER = 137,

        ACTION_CHARACTER_BOOST_DAMAGES_PERCENT = 138,

        ACTION_CHARACTER_ENERGY_POINTS_WIN = 139,

        ACTION_CHARACTER_PASS_NEXT_TURN = 140,

        ACTION_CHARACTER_KILL = 141,

        ACTION_CHARACTER_BOOST_PHYSICAL_DAMAGES = 142,

        ACTION_CHARACTER_LIFE_POINTS_WIN_WITHOUT_BOOST = 143,

        ACTION_CHARACTER_LIFE_POINTS_LOST_NO_BOOST = 144,

        ACTION_CHARACTER_DEBOOST_DAMAGES = 145,

        ACTION_CHARACTER_CURSE = 146,

        ACTION_CHARACTER_RESURECT_ALLY_IN_FIGHT = 147,

        ACTION_CHARACTER_ADD_FOLLOWING_CHARACTER = 148,

        ACTION_CHARACTER_CHANGE_LOOK = 149,

        ACTION_CHARACTER_MAKE_INVISIBLE = 150,

        ACTION_CHARACTER_DEBOOST_CHANCE = 152,

        ACTION_CHARACTER_DEBOOST_VITALITY = 153,

        ACTION_CHARACTER_DEBOOST_AGILITY = 154,

        ACTION_CHARACTER_DEBOOST_INTELLIGENCE = 155,

        ACTION_CHARACTER_DEBOOST_WISDOM = 156,

        ACTION_CHARACTER_DEBOOST_STRENGTH = 157,

        ACTION_CHARACTER_BOOST_MAXIMUM_WEIGHT = 158,

        ACTION_CHARACTER_DEBOOST_MAXIMUM_WEIGHT = 159,

        ACTION_CHARACTER_BOOST_ACTION_POINTS_LOST_DODGE = 160,

        ACTION_CHARACTER_BOOST_MOVEMENT_POINTS_LOST_DODGE = 161,

        ACTION_CHARACTER_DEBOOST_ACTION_POINTS_LOST_DODGE = 162,

        ACTION_CHARACTER_DEBOOST_MOVEMENT_POINTS_LOST_DODGE = 163,

        ACTION_CHARACTER_BOOST_ONE_WEAPON_DAMAGE_PERCENT = 165,

        ACTION_CHARACTER_DEBOOST_ACTION_POINTS = 168,

        ACTION_CHARACTER_DEBOOST_MOVEMENT_POINTS = 169,

        ACTION_CHARACTER_DEBOOST_CRITICAL_HIT = 171,

        ACTION_CHARACTER_DEBOOST_MAGICAL_REDUCTION = 172,

        ACTION_CHARACTER_DEBOOST_PHYSICAL_REDUCTION = 173,

        ACTION_CHARACTER_BOOST_INITIATIVE = 174,

        ACTION_CHARACTER_DEBOOST_INITIATIVE = 175,

        ACTION_CHARACTER_BOOST_MAGIC_FIND = 176,

        ACTION_CHARACTER_DEBOOST_MAGIC_FIND = 177,

        ACTION_CHARACTER_BOOST_HEAL_BONUS = 178,

        ACTION_CHARACTER_DEBOOST_HEAL_BONUS = 179,

        ACTION_CHARACTER_ADD_DOUBLE_USE_SUMMON_SLOT = 180,

        ACTION_SUMMON_CREATURE = 181,

        ACTION_CHARACTER_BOOST_MAXIMUM_SUMMONED_CREATURES = 182,

        ACTION_CHARACTER_BOOST_MAGICAL_REDUCTION = 183,

        ACTION_CHARACTER_BOOST_PHYSICAL_REDUCTION = 184,

        ACTION_CHARACTER_DEBOOST_DAMAGES_PERCENT = 186,

        ACTION_CHARACTER_ALIGNMENT_SIDE_SET = 188,

        ACTION_CHARACTER_INVENTORY_REMOVE_ITEM = 192,

        ACTION_CHARACTER_INVENTORY_ADD_ITEM_CHECK = 193,

        ACTION_CHARACTER_INVENTORY_GAIN_KAMAS = 194,

        ACTION_CHARACTER_TRANSFORM = 197,

        ACTION_DECORS_ADD_OBJECT = 201,

        ACTION_DECORS_REVEAL_UNVISIBLE = 202,

        ACTION_CHARACTER_RESURRECTION = 206,

        ACTION_CHARACTER_BOOST_EARTH_ELEMENT_PERCENT = 210,

        ACTION_CHARACTER_BOOST_WATER_ELEMENT_PERCENT = 211,

        ACTION_CHARACTER_BOOST_AIR_ELEMENT_PERCENT = 212,

        ACTION_CHARACTER_BOOST_FIRE_ELEMENT_PERCENT = 213,

        ACTION_CHARACTER_BOOST_NEUTRAL_ELEMENT_PERCENT = 214,

        ACTION_CHARACTER_DEBOOST_EARTH_ELEMENT_PERCENT = 215,

        ACTION_CHARACTER_DEBOOST_WATER_ELEMENT_PERCENT = 216,

        ACTION_CHARACTER_DEBOOST_AIR_ELEMENT_PERCENT = 217,

        ACTION_CHARACTER_DEBOOST_FIRE_ELEMENT_PERCENT = 218,

        ACTION_CHARACTER_DEBOOST_NEUTRAL_ELEMENT_PERCENT = 219,

        ACTION_CHARACTER_REFLECTOR_UNBOOSTED = 220,

        ACTION_CHARACTER_INVENTORY_ADD_ITEM_RANDOM_NOCHECK = 221,

        ACTION_CHARACTER_INVENTORY_ADD_ITEM_FROM_RANDOM_DROP = 222,

        ACTION_CHARACTER_BOOST_TRAP = 225,

        ACTION_CHARACTER_BOOST_TRAP_PERCENT = 226,

        ACTION_CHARACTER_GAIN_RIDE = 229,

        ACTION_CHARACTER_ENERGY_LOSS_BOOST = 230,

        ACTION_DECORS_PLAY_ANIMATION_D2 = 237,

        ACTION_PLAY_CINEMATIC = 239,

        ACTION_CHARACTER_BOOST_EARTH_ELEMENT_RESIST = 240,

        ACTION_CHARACTER_BOOST_WATER_ELEMENT_RESIST = 241,

        ACTION_CHARACTER_BOOST_AIR_ELEMENT_RESIST = 242,

        ACTION_CHARACTER_BOOST_FIRE_ELEMENT_RESIST = 243,

        ACTION_CHARACTER_BOOST_NEUTRAL_ELEMENT_RESIST = 244,

        ACTION_CHARACTER_DEBOOST_EARTH_ELEMENT_RESIST = 245,

        ACTION_CHARACTER_DEBOOST_WATER_ELEMENT_RESIST = 246,

        ACTION_CHARACTER_DEBOOST_AIR_ELEMENT_RESIST = 247,

        ACTION_CHARACTER_DEBOOST_FIRE_ELEMENT_RESIST = 248,

        ACTION_CHARACTER_DEBOOST_NEUTRAL_ELEMENT_RESIST = 249,

        ACTION_CHARACTER_BOOST_EARTH_ELEMENT_PVP_PERCENT = 250,

        ACTION_CHARACTER_BOOST_WATER_ELEMENT_PVP_PERCENT = 251,

        ACTION_CHARACTER_BOOST_AIR_ELEMENT_PVP_PERCENT = 252,

        ACTION_CHARACTER_BOOST_FIRE_ELEMENT_PVP_PERCENT = 253,

        ACTION_CHARACTER_BOOST_NEUTRAL_ELEMENT_PVP_PERCENT = 254,

        ACTION_CHARACTER_DEBOOST_EARTH_ELEMENT_PVP_PERCENT = 255,

        ACTION_CHARACTER_DEBOOST_WATER_ELEMENT_PVP_PERCENT = 256,

        ACTION_CHARACTER_DEBOOST_AIR_ELEMENT_PVP_PERCENT = 257,

        ACTION_CHARACTER_DEBOOST_FIRE_ELEMENT_PVP_PERCENT = 258,

        ACTION_CHARACTER_DEBOOST_NEUTRAL_ELEMENT_PVP_PERCENT = 259,

        ACTION_CHARACTER_BOOST_EARTH_ELEMENT_PVP_RESIST = 260,

        ACTION_CHARACTER_BOOST_WATER_ELEMENT_PVP_RESIST = 261,

        ACTION_CHARACTER_BOOST_AIR_ELEMENT_PVP_RESIST = 262,

        ACTION_CHARACTER_BOOST_FIRE_ELEMENT_PVP_RESIST = 263,

        ACTION_CHARACTER_BOOST_NEUTRAL_ELEMENT_PVP_RESIST = 264,

        ACTION_CHARACTER_LIFE_LOST_CASTER_MODERATOR = 265,

        ACTION_CHARACTER_STEAL_CHANCE = 266,

        ACTION_CHARACTER_STEAL_VITALITY = 267,

        ACTION_CHARACTER_STEAL_AGILITY = 268,

        ACTION_CHARACTER_STEAL_INTELLIGENCE = 269,

        ACTION_CHARACTER_STEAL_WISDOM = 270,

        ACTION_CHARACTER_STEAL_STRENGTH = 271,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_MISSING_FROM_WATER = 275,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_MISSING_FROM_EARTH = 276,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_MISSING_FROM_AIR = 277,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_MISSING_FROM_FIRE = 278,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_MISSING = 279,

        ACTION_BOOST_SPELL_RANGE_MIN = 280,

        ACTION_BOOST_SPELL_RANGE_MAX = 281,

        ACTION_BOOST_SPELL_RANGEABLE = 282,

        ACTION_BOOST_SPELL_DMG = 283,

        ACTION_BOOST_SPELL_HEAL = 284,

        ACTION_BOOST_SPELL_AP_COST = 285,

        ACTION_BOOST_SPELL_CAST_INTVL = 286,

        ACTION_BOOST_SPELL_CC = 287,

        ACTION_BOOST_SPELL_CASTOUTLINE = 288,

        ACTION_BOOST_SPELL_NOLINEOFSIGHT = 289,

        ACTION_BOOST_SPELL_MAXPERTURN = 290,

        ACTION_BOOST_SPELL_MAXPERTARGET = 291,

        ACTION_BOOST_SPELL_CAST_INTVL_SET = 292,

        ACTION_BOOST_SPELL_BASE_DMG = 293,

        ACTION_DEBOOST_SPELL_RANGE_MAX = 294,

        ACTION_DEBOOST_SPELL_RANGE_MIN = 295,

        ACTION_DEBOOST_SPELL_AP_COST = 296,

        ACTION_FIGHT_DISPELL_TEMPORARY_OBJECT = 310,

        ACTION_CHARACTER_STEAL_RANGE = 320,

        ACTION_CHARACTER_CHANGE_COLOR = 333,

        ACTION_CHARACTER_ADD_APPEARANCE = 335,

        ACTION_REFRESH_MAP_NPC_ONLY_FOR_ME_IN_ROLEPLAY = 350,

        ACTION_REFRESH_MAP_NPC_FOR_EVERYONE_IN_ROLEPLAY = 351,

        ACTION_FIGHT_ADD_TRAP_CASTING_SPELL = 400,

        ACTION_FIGHT_ADD_GLYPH_CASTING_SPELL = 401,

        ACTION_FIGHT_ADD_GLYPH_CASTING_SPELL_ENDTURN = 402,

        ACTION_FIGHT_KILL_AND_SUMMON = 405,

        ACTION_CHARACTER_DISPELL_SPELL = 406,

        ACTION_CHARACTER_LIFE_POINTS_WIN_NO_BOOST = 407,

        ACTION_CHARACTER_BOOST_AP_ATTACK = 410,

        ACTION_CHARACTER_DEBOOST_AP_ATTACK = 411,

        ACTION_CHARACTER_BOOST_MP_ATTACK = 412,

        ACTION_CHARACTER_DEBOOST_MP_ATTACK = 413,

        ACTION_CHARACTER_BOOST_PUSH_DAMAGE = 414,

        ACTION_CHARACTER_DEBOOST_PUSH_DAMAGE = 415,

        ACTION_CHARACTER_BOOST_PUSH_DAMAGE_REDUCTION = 416,

        ACTION_CHARACTER_DEBOOST_PUSH_DAMAGE_REDUCTION = 417,

        ACTION_CHARACTER_BOOST_CRITICAL_DAMAGES_BONUS = 418,

        ACTION_CHARACTER_DEBOOST_CRITICAL_DAMAGES_BONUS = 419,

        ACTION_CHARACTER_BOOST_CRITICAL_DAMAGES_REDUCTION = 420,

        ACTION_CHARACTER_DEBOOST_CRITICAL_DAMAGES_REDUCTION = 421,

        ACTION_CHARACTER_BOOST_EARTH_DAMAGES = 422,

        ACTION_CHARACTER_DEBOOST_EARTH_DAMAGES = 423,

        ACTION_CHARACTER_BOOST_FIRE_DAMAGES = 424,

        ACTION_CHARACTER_DEBOOST_FIRE_DAMAGES = 425,

        ACTION_CHARACTER_BOOST_WATER_DAMAGES = 426,

        ACTION_CHARACTER_DEBOOST_WATER_DAMAGES = 427,

        ACTION_CHARACTER_BOOST_AIR_DAMAGES = 428,

        ACTION_CHARACTER_DEBOOST_AIR_DAMAGES = 429,

        ACTION_CHARACTER_BOOST_NEUTRAL_DAMAGES = 430,

        ACTION_CHARACTER_DEBOOST_NEUTRAL_DAMAGES = 431,

        ACTION_CHARACTER_ACTION_POINTS_STEAL_NO_EVADE = 440,

        ACTION_CHARACTER_MOVEMENT_POINTS_STEAL_NO_EVADE = 441,

        ACTION_CHANGE_COMPASS_BY_COORD = 509,

        ACTION_ADD_PRISM = 513,

        ACTION_SHOW_TAX_COLLECTOR_LIST = 516,

        ACTION_EXCHANGE_DECRAFT_OPEN = 517,

        ACTION_GOTO_WAYPOINT = 600,

        ACTION_CHARACTER_LEARN_JOB = 603,

        ACTION_CHARACTER_LEARN_SPELL_LEVEL = 604,

        ACTION_CHARACTER_GAIN_XP = 605,

        ACTION_CHARACTER_GAIN_WISDOM = 606,

        ACTION_CHARACTER_GAIN_STRENGTH = 607,

        ACTION_CHARACTER_GAIN_CHANCE = 608,

        ACTION_CHARACTER_GAIN_AGILITY = 609,

        ACTION_CHARACTER_GAIN_VITALITY = 610,

        ACTION_CHARACTER_GAIN_INTELLIGENCE = 611,

        ACTION_CHARACTER_GAIN_STATS_POINTS = 612,

        ACTION_CHARACTER_GAIN_JOB_XP = 614,

        ACTION_CHARACTER_UNLEARN_JOB = 615,

        ACTION_CHARACTER_READ_BOOK = 620,

        ACTION_CHARACTER_SUMMON_MONSTER = 621,

        ACTION_GOTO_HOUSE = 622,

        ACTION_CHARACTER_SUMMON_MONSTER_GROUP = 623,

        ACTION_CHARACTER_UNLEARN_GUILDSPELL = 624,

        ACTION_CHARACTER_RESET_CHARACS = 626,

        ACTION_CHARACTER_SUMMON_MONSTER_GROUP_SET_MAP = 627,

        ACTION_CHARACTER_SUMMON_MONSTER_GROUP_DYNAMIC = 628,

        ACTION_CHARACTER_LEARN_SPELL = 629,

        ACTION_CHARACTER_SEND_INFORMATION_TEXT = 630,

        ACTION_CHARACTER_SEND_ERROR_TEXT = 632,

        ACTION_CHARACTER_GAIN_HONOUR = 640,

        ACTION_CHARACTER_GAIN_DISHONOUR = 641,

        ACTION_CHARACTER_LOOSE_HONOUR = 642,

        ACTION_CHARACTER_LOOSE_DISHONOUR = 643,

        ACTION_MAP_RESURECTION_ALLIES = 645,

        ACTION_MAP_HEAL_ALLIES = 646,

        ACTION_MAP_FORCE_ENNEMIES_GHOST = 647,

        ACTION_FORCE_ENNEMY_GHOST = 648,

        ACTION_FAKE_ALIGNMENT = 649,

        ACTION_SET_STATED_ELEMENT_STATE = 652,

        ACTION_INSTANCIEDMAP_LEAVE = 654,

        ACTION_NOOP = 666,

        ACTION_KILL_FIGHT = 667,

        ACTION_INCARNATION = 669,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_REDUCED_BY_CASTER = 670,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_NOT_REDUCED = 671,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_MIDLIFE = 672,

        ACTION_CHARACTER_REFERENCEMENT = 699,

        ACTION_ITEM_CHANGE_EFFECT = 700,

        ACTION_ITEM_ADD_EFFECT = 701,

        ACTION_ITEM_ADD_DURABILITY = 702,

        ACTION_CAPTURE_SOUL = 705,

        ACTION_CAPTURE_RIDE = 706,

        ACTION_ITEM_EQUIP_PRESET = 707,

        ACTION_CHARACTER_ADD_COST_TO_ACTION = 710,

        ACTION_LADDER_SUPERRACE = 715,

        ACTION_LADDER_RACE = 716,

        ACTION_LADDER_ID = 717,

        ACTION_PVP_LADDER = 720,

        ACTION_CHARACTER_LEARN_SPELL_TEMPORARY = 722,

        ACTION_GAIN_TITLE = 724,

        ACTION_CHARACTER_RENAME_INVALID_GUILD = 725,

        ACTION_GAIN_ORNAMENT = 726,

        ACTION_TELEPORT_NEAREST_PRISM = 730,

        ACTION_AUTO_AGGRESS_ENEMY_PLAYER = 731,

        ACTION_RESIST_AUTO_AGGRESS = 732,

        ACTION_SHUSHU_STACK_RUNE_WEAPON = 740,

        ACTION_SHUSHU_STOCKED_RUNE = 741,

        ACTION_SHUSHU_STACK_RUNE = 742,

        ACTION_BOOST_SOUL_CAPTURE_BONUS = 750,

        ACTION_BOOST_RIDE_XP_BONUS = 751,

        ACTION_CHARACTER_BOOST_TAKLE_EVADE = 752,

        ACTION_CHARACTER_BOOST_TAKLE_BLOCK = 753,

        ACTION_CHARACTER_DEBOOST_TAKLE_EVADE = 754,

        ACTION_CHARACTER_DEBOOST_TAKLE_BLOCK = 755,

        ACTION_REMOVE_ON_MOVE = 760,

        ACTION_CHARACTER_SACRIFY = 765,

        ACTION_CLOCKWISE_CONFUSION_DEGREE = 770,

        ACTION_CLOCKWISE_CONFUSION_PI_2 = 771,

        ACTION_CLOCKWISE_CONFUSION_PI_4 = 772,

        ACTION_COUNTER_CLOCKWISE_CONFUSION_DEGREE = 773,

        ACTION_COUNTER_CLOCKWISE_CONFUSION_PI_2 = 774,

        ACTION_COUNTER_CLOCKWISE_CONFUSION_PI_4 = 775,

        ACTION_CHARACTER_BOOST_PERMANENT_DAMAGE_PERCENT = 776,

        ACTION_CHARACTER_CHANGE_RESPAWN_MAP_BY_REF = 778,

        ACTION_CHARACTER_TELEPORT_ON_PREVIOUS_MAP = 779,

        ACTION_CHARACTER_SUMMON_DEAD_ALLY_IN_FIGHT = 780,

        ACTION_CHARACTER_UNLUCKY = 781,

        ACTION_CHARACTER_MAXIMIZE_ROLL = 782,

        ACTION_CHARACTER_PUSH_UP_TO = 783,

        ACTION_CHARACTER_TELEPORT_TO_FIGHT_START_POS = 784,

        ACTION_CHARACTER_WALK_FOUR_DIR = 785,

        ACTION_CHARACTER_HEAL_ATTACKERS = 786,

        ACTION_CHARACTER_PUNISHMENT = 788,

        ACTION_CHARACTER_LOOSE_ALL_ITEMS_FROM_CATEGORY = 789,

        ACTION_FIND_BOUNTY_TARGET = 790,

        ACTION_MARK_TARGET_MERCENARY = 791,

        ACTION_TARGET_EXECUTE_SPELL = 792,

        ACTION_TARGET_EXECUTE_SPELL_WITH_ANIMATION = 793,

        ACTION_HUNT_TOOL = 795,

        ACTION_CHARACTER_RESTORE_RESPAWN_MAP = 796,

        ACTION_ITEM_CHANGE_DURATION = 805,

        ACTION_ITEM_PETS_SHAPE = 806,

        ACTION_ITEM_PETS_EAT = 807,

        ACTION_PETS_LAST_MEAL = 808,

        ACTION_SIZE = 810,

        ACTION_ITEM_BUFF_CHANGE_DURATION = 811,

        ACTION_ITEM_CHANGE_DURABILITY = 812,

        ACTION_ITEM_UPDATE_DATE = 813,

        ACTION_ITEM_DUNGEON_KEY_DATE = 814,

        ACTION_ITEM_FM_LOST_POWER = 815,

        ACTION_ITEM_RESET_DATE = 816,

        ACTION_ITEM_TELEPORT_FORCE = 825,

        ACTION_ITEM_TELEPORT_MAP_REFERENCE = 826,

        ACTION_FIGHT_CHALLENGE_AGAINST_MONSTER = 905,

        ACTION_FIGHT_CHALLENGE_MIXED_VERSUS_MONSTER = 911,

        ACTION_CHARACTER_SEND_NOTIFICATION_TEXT = 916,

        ACTION_CHARACTER_SEND_NOTIFICATION_ALERT_TEXT = 917,

        ACTION_PET_SET_POWER_BOOST = 939,

        ACTION_PET_POWER_BOOST = 940,

        ACTION_FARM_TEMP_WITHDRAW_ITEM = 946,

        ACTION_FARM_WITHDRAW_ITEM = 947,

        ACTION_FARM_PLACE_ITEM = 948,

        ACTION_MOUNT_RIDE = 949,

        ACTION_FIGHT_SET_STATE = 950,

        ACTION_FIGHT_UNSET_STATE = 951,

        ACTION_FIGHT_DISABLE_STATE = 952,

        ACTION_CREATED_SINCE = 963,

        ACTION_SHOW_PLAYERNAME = 964,

        ACTION_ITEM_LIVING_ID = 970,

        ACTION_ITEM_LIVING_MOOD = 971,

        ACTION_ITEM_LIVING_SKIN = 972,

        ACTION_ITEM_LIVING_CATEGORY = 973,

        ACTION_ITEM_LIVING_LEVEL = 974,

        ACTION_MARK_NEVER_TRADABLE_STRONG = 981,

        ACTION_MARK_NEVER_TRADABLE = 982,

        ACTION_MARK_NOT_TRADABLE = 983,

        ACTION_MARK_LEGIT_OWNER = 984,

        ACTION_SET_CRAFTERMAGE = 985,

        ACTION_MARK_TARGET = 986,

        ACTION_SET_OWNER = 987,

        ACTION_SET_CRAFTER = 988,

        ACTION_SEEK_TARGET = 989,

        ACTION_SHOW_TEXT = 990,

        ACTION_RIDE_INVALID = 994,

        ACTION_RIDE_DETAILS = 995,

        ACTION_ITEM_TELEPORT = 999,

        ACTION_FARM_OBJET_EFFICACITY = 1007,

        ACTION_SUMMON_BOMB = 1008,

        ACTION_CHARACTER_ACTIVATE_BOMB = 1009,

        ACTION_SUMMON_SLAVE = 1011,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_MOVEMENT_POINTS = 1012,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_MOVEMENT_POINTS_FROM_AIR = 1013,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_MOVEMENT_POINTS_FROM_WATER = 1014,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_MOVEMENT_POINTS_FROM_FIRE = 1015,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_MOVEMENT_POINTS_FROM_EARTH = 1016,

        ACTION_TARGET_EXECUTE_SPELL_ON_SOURCE = 1017,

        ACTION_SOURCE_EXECUTE_SPELL_ON_TARGET = 1018,

        ACTION_SOURCE_EXECUTE_SPELL_ON_SOURCE = 1019,

        ACTION_CHARACTER_BOOST_SHIELD_BASED_ON_CASTER_LEVEL = 1020,

        ACTION_CHARACTER_PUSH_FORCE = 1021,

        ACTION_CHARACTER_PULL_FORCE = 1022,

        ACTION_CHARACTER_EXCHANGE_PLACES_FORCE = 1023,

        ACTION_CHARACTER_ADD_ILLUSION_RANDOM = 1024,

        ACTION_FORCE_TRAP_TRIGGER = 1025,

        ACTION_FORCE_GLYPH_TRIGGER = 1026,

        ACTION_BOMB_COMBO_BONUS = 1027,

        ACTION_BOMB_TRIGGER_POWDER = 1028,

        ACTION_CHARACTER_VANISH = 1029,

        ACTION_FIGHT_ADD_POWDER_CASTING_SPELL = 1030,

        ACTION_CHARACTER_PASS_CURRENT_TURN = 1031,

        ACTION_MARK_LEGIT_OWNER_TIMESTAMP = 1032,

        ACTION_CHARACTER_DEBOOST_VITALITY_PERCENT_STATIC = 1033,

        ACTION_CHARACTER_SUMMON_DEAD_ALLY_AS_SUMMON_IN_FIGHT = 1034,

        ACTION_CHARACTER_ADD_SPELL_COOLDOWN = 1035,

        ACTION_CHARACTER_REMOVE_SPELL_COOLDOWN = 1036,

        ACTION_CHARACTER_LIFE_POINTS_WIN_ZOBAL = 1037,

        ACTION_CHARACTER_AURA = 1038,

        ACTION_CHARACTER_BOOST_SHIELD_BASED_ON_CASTER_LIFE = 1039,

        ACTION_CHARACTER_BOOST_SHIELD = 1040,

        ACTION_CHARACTER_GET_PUSHED = 1041,

        ACTION_CHARACTER_GET_PULLED = 1042,

        ACTION_CHARACTER_PULL_UP_TO = 1043,

        ACTION_CHARACTER_PROTECTION_FROM_SPELL = 1044,

        ACTION_CHARACTER_SET_SPELL_COOLDOWN = 1045,

        ACTION_CHARACTER_LIFE_POINTS_MALUS = 1047,

        ACTION_CHARACTER_LIFE_POINTS_MALUS_PERCENT = 1048,

        ACTION_CHARACTER_GAIN_LEVEL = 1049,

        ACTION_CHARACTER_EXIT_DUNGEON = 1051,

        ACTION_CHARACTER_RESUME_DUNGEON = 1052,

        ACTION_CHARACTER_ENTER_DUNGEON = 1053,

        ACTION_CHARACTER_BOOST_DAMAGES_PERCENT_SPELLS = 1054,

        ACTION_CHARACTER_CLEAR_DUNGEON_SAVE = 1055,

        ACTION_CHARACTER_BOOST_SHIELD_BASED_ON_CASTER_LIFE_TURN_BASED = 1056,

        ACTION_STATIC_VALUE_MODIFY = 1057,

        ACTION_STATIC_VALUE_SET = 1058,

        ACTION_CHARACTER_CUSTOM_MOUNT = 1059,

        ACTION_CHARACTER_ADD_SCALE_FLAT = 1060,

        ACTION_CHARACTER_SHARE_DAMAGES = 1061,

        ACTION_OPEN_URL = 1062,

        ACTION_CHARACTER_LIFE_POINTS_LOST_NO_BOOST_FROM_EARTH = 1063,

        ACTION_CHARACTER_LIFE_POINTS_LOST_NO_BOOST_FROM_AIR = 1064,

        ACTION_CHARACTER_LIFE_POINTS_LOST_NO_BOOST_FROM_WATER = 1065,

        ACTION_CHARACTER_LIFE_POINTS_LOST_NO_BOOST_FROM_FIRE = 1066,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_TARGET_LIFE_FROM_AIR = 1067,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_TARGET_LIFE_FROM_WATER = 1068,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_TARGET_LIFE_FROM_FIRE = 1069,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_TARGET_LIFE_FROM_EARTH = 1070,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_TARGET_LIFE = 1071,

        ACTION_CHARACTER_TAUNT = 1072,

        ACTION_ITEM_CHANGE_EFFECT_SAFE = 1073,

        ACTION_MEETING_POINT = 1074,

        ACTION_CHARACTER_SHORTEN_ACTIVE_EFFECTS_DURATION = 1075,

        ACTION_CHARACTER_BOOST_RESIST_PERCENT = 1076,

        ACTION_CHARACTER_DEBOOST_RESIST_PERCENT = 1077,

        ACTION_CHARACTER_BOOST_VITALITY_PERCENT_STATIC = 1078,

        ACTION_CHARACTER_DEBOOST_ACTION_POINTS_DODGEABLE = 1079,

        ACTION_CHARACTER_DEBOOST_MOVEMENT_POINTS_DODGEABLE = 1080,

        ACTION_ITEM_EXTRA_PODS = 1081,

        ACTION_ITEM_GIFT_OPEN = 1082,

        ACTION_ITEM_GIFT_PACKING = 1083,

        ACTION_ITEM_GIFT_CONTENT = 1084,

        ACTION_ITEM_GIFT_QUANTITY = 1085,

        ACTION_ITEM_GIFT_TARGET = 1086,

        ACTION_ITEM_GIFT_CHOOSE_TARGET = 1087,

        ACTION_CHARACTER_BOOST_SHIELD_TURN_BASED = 1088,

        ACTION_FIGHT_ADD_GLYPH_AURA = 1091,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_TARGET_MISSING_MAX_LIFE = 1092,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_TARGET_MISSING_MAX_LIFE_AIR = 1093,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_TARGET_MISSING_MAX_LIFE_FIRE = 1094,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_TARGET_MISSING_MAX_LIFE_WATER = 1095,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_TARGET_MISSING_MAX_LIFE_EARTH = 1096,

        ACTION_CHARACTER_ADD_ILLUSION_MIRROR = 1097,

        ACTION_ITEM_CURSE_USED_ITEM = 1098,

        ACTION_FIGHT_ROLLBACK_TURN_BEGIN_POSITION = 1099,

        ACTION_FIGHT_ROLLBACK_PREVIOUS_POSITION = 1100,

        ACTION_FIGHT_TELESWAP = 1101,

        ACTION_SPEAKING_ITEM = 1102,

        ACTION_FIGHT_PUSH_NO_DAMAGE = 1103,

        ACTION_FIGHT_TELESWAP_MIRROR = 1104,

        ACTION_FIGHT_TELESWAP_MIRROR_CASTER = 1105,

        ACTION_FIGHT_TELESWAP_MIRROR_IMPACT_POINT = 1106,

        ACTION_ITEM_GUILD_RENAME = 1107,

        ACTION_ITEM_GUILD_EMBLEM_CHANGE = 1108,

        ACTION_FIGHT_LIFE_POINTS_WIN_PERCENT = 1109,

        ACTION_ITEM_SUMMON_MONSTER_REWARD_RATE = 1110,

        ACTION_ITEM_SUMMON_MONSTER_GROUP_MAX_LOOT_SHARES = 1111,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_MISSING_MAX_LIFE = 1118,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_MISSING_MAX_LIFE_AIR = 1119,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_MISSING_MAX_LIFE_FIRE = 1120,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_MISSING_MAX_LIFE_WATER = 1121,

        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_MISSING_MAX_LIFE_EARTH = 1122,

        ACTION_FIGHT_SPLASH_RAW_TAKEN_DAMAGE = 1123,

        ACTION_FIGHT_SPLASH_RAW_TAKEN_DAMAGE_NEUTRAL = 1124,

        ACTION_FIGHT_SPLASH_RAW_TAKEN_DAMAGE_AIR = 1125,

        ACTION_FIGHT_SPLASH_RAW_TAKEN_DAMAGE_FIRE = 1126,

        ACTION_FIGHT_SPLASH_RAW_TAKEN_DAMAGE_WATER = 1127,

        ACTION_FIGHT_SPLASH_RAW_TAKEN_DAMAGE_EARTH = 1128,

        ACTION_CHARACTER_MANA_USE_KILL_LIFE_AIR = 1131,

        ACTION_CHARACTER_MANA_USE_KILL_LIFE_WATER = 1132,

        ACTION_CHARACTER_MANA_USE_KILL_LIFE_FIRE = 1133,

        ACTION_CHARACTER_MANA_USE_KILL_LIFE_NEUTRAL = 1134,

        ACTION_CHARACTER_MANA_USE_KILL_LIFE_EARTH = 1135,

        ACTION_CHARACTER_MOVEMENT_USE_KILL_LIFE_AIR = 1136,

        ACTION_CHARACTER_MOVEMENT_USE_KILL_LIFE_WATER = 1137,

        ACTION_CHARACTER_MOVEMENT_USE_KILL_LIFE_FIRE = 1138,

        ACTION_CHARACTER_MOVEMENT_USE_KILL_LIFE_NEUTRAL = 1139,

        ACTION_CHARACTER_MOVEMENT_USE_KILL_LIFE_EARTH = 1140,

        ACTION_ACHIEVEMENT_OBJECTIVE_VALIDATE = 1142,

        ACTION_FIGHT_BOOST_WEAPON_DAMAGE_POWER = 1144,

        ACTION_ITEM_ALLIANCE_EMBLEM_CHANGE = 1145,

        ACTION_ITEM_ALLIANCE_RENAME = 1146,

        ACTION_CHARACTER_GAIN_XP_WITH_LEVEL = 1149,

        ACTION_REFRESH_ELEMENT = 1150,

        ACTION_ITEM_MIMICRY_OBJ_GID = 1151,

        ACTION_MARK_NOT_TRADABLE_BACKUP = 1152,

        ACTION_ADD_TAX_COLLECTOR = 1153,

        ACTION_ADD_PRISM_MODULE = 1154,

        ACTION_ITEM_TELEPORT_MAP_REFERENCE_FORCE = 1155,

        ACTION_CHARACTER_MULTIPLY_RECEIVED_HEAL = 1159,

        ACTION_CASTER_EXECUTE_SPELL = 1160,

        ACTION_SET_COMPANION = 1161,

        ACTION_CHANGE_COMPASS_BY_REF = 1162,

        ACTION_CHARACTER_MULTIPLY_RECEIVED_DAMAGE = 1163,

        ACTION_CHARACTER_GIVE_LIFE_WITH_RATIO = 1164,

        ACTION_FIGHT_ADD_GLYPH_CASTING_SPELL_IMMEDIATE = 1165,

        ACTION_FIGHT_BOOST_GLYPH_DAMAGE_POWER = 1166,

        ACTION_FIGHT_BOOST_RUNE_DAMAGE_POWER = 1167,

        ACTION_GET_PORTAL_QUEST = 1168,

        ACTION_USE_PORTAL = 1169,

        ACTION_GET_TREASURE_QUEST = 1170,

        ACTION_CHARACTER_BOOST_DEALT_DAMAGE_PERCENT_MULTIPLIER = 1171,

        ACTION_CHARACTER_DEBOOST_DEALT_DAMAGE_PERCENT_MULTIPLIER = 1172,

        ACTION_GET_LEGENDARY_TREASURE_QUEST = 1173,

        ACTION_STOP_XP = 1174,

        ACTION_CAST_STARTING_SPELL = 1175,

        ACTION_ITEM_WRAPPER_LOOK_OBJ_GID = 1176,

        ACTION_ITEM_TELEPORT_NEXT_MAP = 1177,

        ACTION_ITEM_TELEPORT_PREVIOUS_MAP = 1178,

        ACTION_ITEM_WRAPPER_COMPATIBLE_OBJ_TYPE = 1179,

        ACTION_CHARACTER_READ_EXTERNAL_BOOK = 1180,

        ACTION_FIGHT_ADD_PORTAL = 1181,

        ACTION_FIGHT_USE_PORTAL = 1182,

        ACTION_FIGHT_DISABLE_PORTAL = 1183,

        ACTION_CHARACTER_GAIN_JOB_LEVEL_FROM_LEVEL_ONE = 1184,

        ACTION_ITEM_RESET_EFFECTS = 1185,

        ACTION_RIDE_HARNESS_GID = 1187,

        ACTION_RIDE_GAIN_CAPACITY = 1188,

        ACTION_CHARACTER_ADD_DOUBLE_NO_SUMMON_SLOT = 1189,

        ACTION_FIGHT_SPLASH_FINAL_TAKEN_DAMAGE = 1223,

        ACTION_FIGHT_SPLASH_FINAL_TAKEN_DAMAGE_NEUTRAL = 1224,

        ACTION_FIGHT_SPLASH_FINAL_TAKEN_DAMAGE_AIR = 1225,

        ACTION_FIGHT_SPLASH_FINAL_TAKEN_DAMAGE_FIRE = 1226,

        ACTION_FIGHT_SPLASH_FINAL_TAKEN_DAMAGE_WATER = 1227,

        ACTION_FIGHT_SPLASH_FINAL_TAKEN_DAMAGE_EARTH = 1228,

        ACTION_TARGET_EXECUTE_SPELL_ON_SOURCE_GLOBAL_LIMITATION = 2017,

        ACTION_DISPEL_GLYPHS_OF_TARGET = 2018,

        ACTION_DISPEL_TRAPS_OF_TARGET = 2019,

        ACTION_FIGHT_SPLASH_HEAL = 2020,

        ACTION_NUGGETS_REPARTITION = 2021,

        ACTION_FIGHT_ADD_RUNE_CASTING_SPELL = 2022,

        ACTION_FORCE_RUNE_TRIGGER = 2023,

        ACTION_DISPEL_RUNES_OF_TARGET = 2024,

        ACTION_CHARACTER_OPEN_HAVENBAG_STORAGE = 2025,

        ACTION_CHARACTER_HAVENBAG_LOTTERY = 2026,

        ACTION_CONTROL_ENTITY = 2027,

        ACTION_INHERITE_CHARAC = 2028,

        ACTION_FINISH_MOVE = 2029,

        ACTION_CHARACTER_LEARN_FINISH_MOVE = 2030,

        ACTION_CHARACTER_LEARN_HAVEN_BAG_THEME = 2031,

        ACTION_CASTER_EXECUTE_SPELL_GLOBAL_LIMITATION = 2160,

        ACTION_TARGET_EXECUTE_SPELL_GLOBAL_LIMITATION = 2792,

        ACTION_TARGET_EXECUTE_SPELL_WITH_ANIMATION_GLOBAL_LIMITATION = 2793,

        ACTION_TARGET_EXECUTE_SPELL_ON_CELL = 2794,

        ACTION_TARGET_EXECUTE_SPELL_ON_CELL_GLOBAL_LIMITATION = 2795,

        ACTION_FIGHT_KILL_AND_SUMMON_SLAVE = 2796,

        ACTION_CHARACTER_LEARN_SMILEY_PACK = 2797,

        ACTION_CHARACTER_BOOST_DEALT_DAMAGE_PERCENT_MULTIPLIER_MELEE = 2800,

        ACTION_CHARACTER_DEBOOST_DEALT_DAMAGE_PERCENT_MULTIPLIER_MELEE = 2801,

        ACTION_CHARACTER_BOOST_RECEIVED_DAMAGE_PERCENT_MULTIPLIER_MELEE = 2802,

        ACTION_CHARACTER_DEBOOST_RECEIVED_DAMAGE_PERCENT_MULTIPLIER_MELEE = 2803,

        ACTION_CHARACTER_BOOST_DEALT_DAMAGE_PERCENT_MULTIPLIER_DISTANCE = 2804,

        ACTION_CHARACTER_DEBOOST_DEALT_DAMAGE_PERCENT_MULTIPLIER_DISTANCE = 2805,

        ACTION_CHARACTER_BOOST_RECEIVED_DAMAGE_PERCENT_MULTIPLIER_DISTANCE = 2806,

        ACTION_CHARACTER_DEBOOST_RECEIVED_DAMAGE_PERCENT_MULTIPLIER_DISTANCE = 2807,

        ACTION_CHARACTER_BOOST_DEALT_DAMAGE_PERCENT_MULTIPLIER_WEAPON = 2808,

        ACTION_CHARACTER_DEBOOST_DEALT_DAMAGE_PERCENT_MULTIPLIER_WEAPON = 2809,

        ACTION_CHARACTER_BOOST_RECEIVED_DAMAGE_PERCENT_MULTIPLIER_WEAPON = 2810,

        ACTION_CHARACTER_DEBOOST_RECEIVED_DAMAGE_PERCENT_MULTIPLIER_WEAPON = 2811,

        ACTION_CHARACTER_BOOST_DEALT_DAMAGE_PERCENT_MULTIPLIER_SPELLS = 2812,

        ACTION_CHARACTER_DEBOOST_DEALT_DAMAGE_PERCENT_MULTIPLIER_SPELLS = 2813,

        ACTION_CHARACTER_BOOST_RECEIVED_DAMAGE_PERCENT_MULTIPLIER_SPELLS = 2814,

        ACTION_CHARACTER_DEBOOST_RECEIVED_DAMAGE_PERCENT_MULTIPLIER_SPELLS = 2815,

        ACTION_BOOST_CHARAC_CONVERT = 2816,

        ACTION_BUY_IN_BID_HOUSE = 2817,

        ACTION_HOME_MADE = 2818,

        ACTION_EVOLUTIVE_OBJECT_EXPERIENCE = 2819,

        ACTION_SUPERFOOD_EXPERIENCE = 2820,

        ACTION_EVOLUTIVE_PET_LEVEL = 2821,

        ACTION_CHARACTER_LIFE_POINTS_LOST_FROM_BEST_ELEMENT = 2822,

        ACTION_CHARACTER_PLAY_EMOTICON = 2823,

        ACTION_BOOST_ALL_SPELL_BASE_DMG = 2824,

        PREVENT_FUTURE_SMITHMAGIC = 2825,

        SMITHMAGIC_FORCE_WEIGHT = 2826,

        SMITHMAGIC_FORCE_PROBABILITY = 2827,

        ACTION_CHARACTER_LIFE_POINTS_STEAL_FROM_BEST_ELEMENT = 2828,

        ACTION_FIGHT_SPLASH_RAW_TAKEN_DAMAGE_BEST_ELEMENT = 2829,

        ACTION_FIGHT_SPLASH_FINAL_TAKEN_DAMAGE_BEST_ELEMENT = 2830,

        WIPWIPWIP = 2831,

        ACTION_ITEM_EXPIRATION = 2833,

        ACTION_CHARACTER_BOOST_STRENGTH_PERCENT = 2834,

        ACTION_CHARACTER_DEBOOST_STRENGTH_PERCENT = 2835,

        ACTION_CHARACTER_BOOST_AGILITY_PERCENT = 2836,

        ACTION_CHARACTER_DEBOOST_AGILITY_PERCENT = 2837,

        ACTION_CHARACTER_BOOST_INTELLIGENCE_PERCENT = 2838,

        ACTION_CHARACTER_DEBOOST_INTELLIGENCE_PERCENT = 2839,

        ACTION_CHARACTER_BOOST_CHANCE_PERCENT = 2840,

        ACTION_CHARACTER_DEBOOST_CHANCE_PERCENT = 2841,

        ACTION_CHARACTER_BOOST_WISDOM_PERCENT = 2842,

        ACTION_CHARACTER_DEBOOST_WISDOM_PERCENT = 2843,

        ACTION_CHARACTER_BOOST_VITALITY_PERCENT = 2844,

        ACTION_CHARACTER_DEBOOST_VITALITY_PERCENT = 2845,

        ACTION_CHARACTER_BOOST_ACTION_POINTS_PERCENT = 2846,

        ACTION_CHARACTER_DEBOOST_ACTION_POINTS_PERCENT = 2847,

        ACTION_CHARACTER_BOOST_MOVEMENT_POINTS_PERCENT = 2848,

        ACTION_CHARACTER_DEBOOST_MOVEMENT_POINTS_PERCENT = 2849,

        ACTION_CHARACTER_BOOST_TAKLE_BLOCK_PERCENT = 2850,

        ACTION_CHARACTER_DEBOOST_TAKLE_BLOCK_PERCENT = 2851,

        ACTION_CHARACTER_BOOST_TAKLE_EVADE_PERCENT = 2852,

        ACTION_CHARACTER_DEBOOST_TAKLE_EVADE_PERCENT = 2853,

        ACTION_CHARACTER_BOOST_ACTION_POINTS_LOST_DODGE_PERCENT = 2854,

        ACTION_CHARACTER_DEBOOST_ACTION_POINTS_LOST_DODGE_PERCENT = 2855,

        ACTION_CHARACTER_BOOST_MOVEMENT_POINTS_LOST_DODGE_PERCENT = 2856,

        ACTION_CHARACTER_DEBOOST_MOVEMENT_POINTS_LOST_DODGE_PERCENT = 2857,

        ACTION_CHARACTER_BOOST_AP_ATTACK_PERCENT = 2858,

        ACTION_CHARACTER_DEBOOST_AP_ATTACK_PERCENT = 2859,

        ACTION_CHARACTER_BOOST_MP_ATTACK_PERCENT = 2860,

        ACTION_CHARACTER_DEBOOST_MP_ATTACK_PERCENT = 2861,

        ACTION_LEGENDARY_STATUS = 2862,

        ACTION_LEGENDARY_POWER_SPELL = 2864,

        ACTION_CHARACTER_GAIN_XP_WO_BOOST = 2865,

        ACTION_NO_SYSTEM_SAVE = 2866,

        ACTION_CHARACTER_BOOST_XP_COEFF = 2867,

        ACTION_CHARACTER_ADD_SCALE_PERCENT = 2868,

        ACTION_CHARACTER_BOOST_JOB_XP_COEFF = 2869,

        PAY_LEAVE_JAIL = 2870,

        ACTION_CHARACTER_LOWER_SCALE_PERCENT = 2871,

        ACTION_CHARACTER_BOOST_THRESHOLD = 2872,

        ACTION_BREACH_RESET_ROOM_SEED = 2873,

        ACTION_BREACH_RESET_ROOM_CHALLENGE = 2874,

        ACTION_CHARACTER_LEARN_SPELL_FORGETTABLE = 2875,

        ACTION_FIGHT_VALIDATE_CHALLENGE = 2876,

        ACTION_FIGHT_INVALIDATE_CHALLENGE = 2877,

        /* Old versions */

        ACTION_CHARACTER_UPDATE_BOOST = 515,

        ACTION_FIGHT_CLOSE_COMBAT = 303,

        ACTION_FIGHT_SPELL_DODGED_PM = 309,

        ACTION_CHARACTER_MOVEMENT_POINTS_USE = 129,

        ACTION_FIGHT_SPELL_DODGED_PA = 308,

        ACTION_CHARACTER_ACTION_POINTS_USE = 102,

        ACTION_CHARACTER_BOOST_DISPELLED = 514,

        ACTION_FIGHT_CAST_SPELL = 300,

        ACTION_NO_MORE_CARRIED = 52,

        ACTION_CHARACTER_DEATH = 103,
    }
}