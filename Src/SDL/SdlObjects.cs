using System;
using System.Runtime.InteropServices;

namespace MyVarUI.SDL
{
   
        public enum SDL_Scancode
		{
			SDL_SCANCODE_UNKNOWN = 0,

			SDL_SCANCODE_A = 4,
			SDL_SCANCODE_B = 5,
			SDL_SCANCODE_C = 6,
			SDL_SCANCODE_D = 7,
			SDL_SCANCODE_E = 8,
			SDL_SCANCODE_F = 9,
			SDL_SCANCODE_G = 10,
			SDL_SCANCODE_H = 11,
			SDL_SCANCODE_I = 12,
			SDL_SCANCODE_J = 13,
			SDL_SCANCODE_K = 14,
			SDL_SCANCODE_L = 15,
			SDL_SCANCODE_M = 16,
			SDL_SCANCODE_N = 17,
			SDL_SCANCODE_O = 18,
			SDL_SCANCODE_P = 19,
			SDL_SCANCODE_Q = 20,
			SDL_SCANCODE_R = 21,
			SDL_SCANCODE_S = 22,
			SDL_SCANCODE_T = 23,
			SDL_SCANCODE_U = 24,
			SDL_SCANCODE_V = 25,
			SDL_SCANCODE_W = 26,
			SDL_SCANCODE_X = 27,
			SDL_SCANCODE_Y = 28,
			SDL_SCANCODE_Z = 29,

			SDL_SCANCODE_1 = 30,
			SDL_SCANCODE_2 = 31,
			SDL_SCANCODE_3 = 32,
			SDL_SCANCODE_4 = 33,
			SDL_SCANCODE_5 = 34,
			SDL_SCANCODE_6 = 35,
			SDL_SCANCODE_7 = 36,
			SDL_SCANCODE_8 = 37,
			SDL_SCANCODE_9 = 38,
			SDL_SCANCODE_0 = 39,

			SDL_SCANCODE_RETURN = 40,
			SDL_SCANCODE_ESCAPE = 41,
			SDL_SCANCODE_BACKSPACE = 42,
			SDL_SCANCODE_TAB = 43,
			SDL_SCANCODE_SPACE = 44,

			SDL_SCANCODE_MINUS = 45,
			SDL_SCANCODE_EQUALS = 46,
			SDL_SCANCODE_LEFTBRACKET = 47,
			SDL_SCANCODE_RIGHTBRACKET = 48,
			SDL_SCANCODE_BACKSLASH = 49,
			SDL_SCANCODE_NONUSHASH = 50,
			SDL_SCANCODE_SEMICOLON = 51,
			SDL_SCANCODE_APOSTROPHE = 52,
			SDL_SCANCODE_GRAVE = 53,
			SDL_SCANCODE_COMMA = 54,
			SDL_SCANCODE_PERIOD = 55,
			SDL_SCANCODE_SLASH = 56,

			SDL_SCANCODE_CAPSLOCK = 57,

			SDL_SCANCODE_F1 = 58,
			SDL_SCANCODE_F2 = 59,
			SDL_SCANCODE_F3 = 60,
			SDL_SCANCODE_F4 = 61,
			SDL_SCANCODE_F5 = 62,
			SDL_SCANCODE_F6 = 63,
			SDL_SCANCODE_F7 = 64,
			SDL_SCANCODE_F8 = 65,
			SDL_SCANCODE_F9 = 66,
			SDL_SCANCODE_F10 = 67,
			SDL_SCANCODE_F11 = 68,
			SDL_SCANCODE_F12 = 69,

			SDL_SCANCODE_PRINTSCREEN = 70,
			SDL_SCANCODE_SCROLLLOCK = 71,
			SDL_SCANCODE_PAUSE = 72,
			SDL_SCANCODE_INSERT = 73,
			SDL_SCANCODE_HOME = 74,
			SDL_SCANCODE_PAGEUP = 75,
			SDL_SCANCODE_DELETE = 76,
			SDL_SCANCODE_END = 77,
			SDL_SCANCODE_PAGEDOWN = 78,
			SDL_SCANCODE_RIGHT = 79,
			SDL_SCANCODE_LEFT = 80,
			SDL_SCANCODE_DOWN = 81,
			SDL_SCANCODE_UP = 82,

			SDL_SCANCODE_NUMLOCKCLEAR = 83,
			SDL_SCANCODE_KP_DIVIDE = 84,
			SDL_SCANCODE_KP_MULTIPLY = 85,
			SDL_SCANCODE_KP_MINUS = 86,
			SDL_SCANCODE_KP_PLUS = 87,
			SDL_SCANCODE_KP_ENTER = 88,
			SDL_SCANCODE_KP_1 = 89,
			SDL_SCANCODE_KP_2 = 90,
			SDL_SCANCODE_KP_3 = 91,
			SDL_SCANCODE_KP_4 = 92,
			SDL_SCANCODE_KP_5 = 93,
			SDL_SCANCODE_KP_6 = 94,
			SDL_SCANCODE_KP_7 = 95,
			SDL_SCANCODE_KP_8 = 96,
			SDL_SCANCODE_KP_9 = 97,
			SDL_SCANCODE_KP_0 = 98,
			SDL_SCANCODE_KP_PERIOD = 99,

			SDL_SCANCODE_NONUSBACKSLASH = 100,
			SDL_SCANCODE_APPLICATION = 101,
			SDL_SCANCODE_POWER = 102,
			SDL_SCANCODE_KP_EQUALS = 103,
			SDL_SCANCODE_F13 = 104,
			SDL_SCANCODE_F14 = 105,
			SDL_SCANCODE_F15 = 106,
			SDL_SCANCODE_F16 = 107,
			SDL_SCANCODE_F17 = 108,
			SDL_SCANCODE_F18 = 109,
			SDL_SCANCODE_F19 = 110,
			SDL_SCANCODE_F20 = 111,
			SDL_SCANCODE_F21 = 112,
			SDL_SCANCODE_F22 = 113,
			SDL_SCANCODE_F23 = 114,
			SDL_SCANCODE_F24 = 115,
			SDL_SCANCODE_EXECUTE = 116,
			SDL_SCANCODE_HELP = 117,
			SDL_SCANCODE_MENU = 118,
			SDL_SCANCODE_SELECT = 119,
			SDL_SCANCODE_STOP = 120,
			SDL_SCANCODE_AGAIN = 121,
			SDL_SCANCODE_UNDO = 122,
			SDL_SCANCODE_CUT = 123,
			SDL_SCANCODE_COPY = 124,
			SDL_SCANCODE_PASTE = 125,
			SDL_SCANCODE_FIND = 126,
			SDL_SCANCODE_MUTE = 127,
			SDL_SCANCODE_VOLUMEUP = 128,
			SDL_SCANCODE_VOLUMEDOWN = 129,
			/* not sure whether there's a reason to enable these */
			/*	SDL_SCANCODE_LOCKINGCAPSLOCK = 130, */
			/*	SDL_SCANCODE_LOCKINGNUMLOCK = 131, */
			/*	SDL_SCANCODE_LOCKINGSCROLLLOCK = 132, */
			SDL_SCANCODE_KP_COMMA = 133,
			SDL_SCANCODE_KP_EQUALSAS400 = 134,

			SDL_SCANCODE_INTERNATIONAL1 = 135,
			SDL_SCANCODE_INTERNATIONAL2 = 136,
			SDL_SCANCODE_INTERNATIONAL3 = 137,
			SDL_SCANCODE_INTERNATIONAL4 = 138,
			SDL_SCANCODE_INTERNATIONAL5 = 139,
			SDL_SCANCODE_INTERNATIONAL6 = 140,
			SDL_SCANCODE_INTERNATIONAL7 = 141,
			SDL_SCANCODE_INTERNATIONAL8 = 142,
			SDL_SCANCODE_INTERNATIONAL9 = 143,
			SDL_SCANCODE_LANG1 = 144,
			SDL_SCANCODE_LANG2 = 145,
			SDL_SCANCODE_LANG3 = 146,
			SDL_SCANCODE_LANG4 = 147,
			SDL_SCANCODE_LANG5 = 148,
			SDL_SCANCODE_LANG6 = 149,
			SDL_SCANCODE_LANG7 = 150,
			SDL_SCANCODE_LANG8 = 151,
			SDL_SCANCODE_LANG9 = 152,

			SDL_SCANCODE_ALTERASE = 153,
			SDL_SCANCODE_SYSREQ = 154,
			SDL_SCANCODE_CANCEL = 155,
			SDL_SCANCODE_CLEAR = 156,
			SDL_SCANCODE_PRIOR = 157,
			SDL_SCANCODE_RETURN2 = 158,
			SDL_SCANCODE_SEPARATOR = 159,
			SDL_SCANCODE_OUT = 160,
			SDL_SCANCODE_OPER = 161,
			SDL_SCANCODE_CLEARAGAIN = 162,
			SDL_SCANCODE_CRSEL = 163,
			SDL_SCANCODE_EXSEL = 164,

			SDL_SCANCODE_KP_00 = 176,
			SDL_SCANCODE_KP_000 = 177,
			SDL_SCANCODE_THOUSANDSSEPARATOR = 178,
			SDL_SCANCODE_DECIMALSEPARATOR = 179,
			SDL_SCANCODE_CURRENCYUNIT = 180,
			SDL_SCANCODE_CURRENCYSUBUNIT = 181,
			SDL_SCANCODE_KP_LEFTPAREN = 182,
			SDL_SCANCODE_KP_RIGHTPAREN = 183,
			SDL_SCANCODE_KP_LEFTBRACE = 184,
			SDL_SCANCODE_KP_RIGHTBRACE = 185,
			SDL_SCANCODE_KP_TAB = 186,
			SDL_SCANCODE_KP_BACKSPACE = 187,
			SDL_SCANCODE_KP_A = 188,
			SDL_SCANCODE_KP_B = 189,
			SDL_SCANCODE_KP_C = 190,
			SDL_SCANCODE_KP_D = 191,
			SDL_SCANCODE_KP_E = 192,
			SDL_SCANCODE_KP_F = 193,
			SDL_SCANCODE_KP_XOR = 194,
			SDL_SCANCODE_KP_POWER = 195,
			SDL_SCANCODE_KP_PERCENT = 196,
			SDL_SCANCODE_KP_LESS = 197,
			SDL_SCANCODE_KP_GREATER = 198,
			SDL_SCANCODE_KP_AMPERSAND = 199,
			SDL_SCANCODE_KP_DBLAMPERSAND = 200,
			SDL_SCANCODE_KP_VERTICALBAR = 201,
			SDL_SCANCODE_KP_DBLVERTICALBAR = 202,
			SDL_SCANCODE_KP_COLON = 203,
			SDL_SCANCODE_KP_HASH = 204,
			SDL_SCANCODE_KP_SPACE = 205,
			SDL_SCANCODE_KP_AT = 206,
			SDL_SCANCODE_KP_EXCLAM = 207,
			SDL_SCANCODE_KP_MEMSTORE = 208,
			SDL_SCANCODE_KP_MEMRECALL = 209,
			SDL_SCANCODE_KP_MEMCLEAR = 210,
			SDL_SCANCODE_KP_MEMADD = 211,
			SDL_SCANCODE_KP_MEMSUBTRACT = 212,
			SDL_SCANCODE_KP_MEMMULTIPLY = 213,
			SDL_SCANCODE_KP_MEMDIVIDE = 214,
			SDL_SCANCODE_KP_PLUSMINUS = 215,
			SDL_SCANCODE_KP_CLEAR = 216,
			SDL_SCANCODE_KP_CLEARENTRY = 217,
			SDL_SCANCODE_KP_BINARY = 218,
			SDL_SCANCODE_KP_OCTAL = 219,
			SDL_SCANCODE_KP_DECIMAL = 220,
			SDL_SCANCODE_KP_HEXADECIMAL = 221,

			SDL_SCANCODE_LCTRL = 224,
			SDL_SCANCODE_LSHIFT = 225,
			SDL_SCANCODE_LALT = 226,
			SDL_SCANCODE_LGUI = 227,
			SDL_SCANCODE_RCTRL = 228,
			SDL_SCANCODE_RSHIFT = 229,
			SDL_SCANCODE_RALT = 230,
			SDL_SCANCODE_RGUI = 231,

			SDL_SCANCODE_MODE = 257,

			/* These come from the USB consumer page (0x0C) */
			SDL_SCANCODE_AUDIONEXT = 258,
			SDL_SCANCODE_AUDIOPREV = 259,
			SDL_SCANCODE_AUDIOSTOP = 260,
			SDL_SCANCODE_AUDIOPLAY = 261,
			SDL_SCANCODE_AUDIOMUTE = 262,
			SDL_SCANCODE_MEDIASELECT = 263,
			SDL_SCANCODE_WWW = 264,
			SDL_SCANCODE_MAIL = 265,
			SDL_SCANCODE_CALCULATOR = 266,
			SDL_SCANCODE_COMPUTER = 267,
			SDL_SCANCODE_AC_SEARCH = 268,
			SDL_SCANCODE_AC_HOME = 269,
			SDL_SCANCODE_AC_BACK = 270,
			SDL_SCANCODE_AC_FORWARD = 271,
			SDL_SCANCODE_AC_STOP = 272,
			SDL_SCANCODE_AC_REFRESH = 273,
			SDL_SCANCODE_AC_BOOKMARKS = 274,

			/* These come from other sources, and are mostly mac related */
			SDL_SCANCODE_BRIGHTNESSDOWN = 275,
			SDL_SCANCODE_BRIGHTNESSUP = 276,
			SDL_SCANCODE_DISPLAYSWITCH = 277,
			SDL_SCANCODE_KBDILLUMTOGGLE = 278,
			SDL_SCANCODE_KBDILLUMDOWN = 279,
			SDL_SCANCODE_KBDILLUMUP = 280,
			SDL_SCANCODE_EJECT = 281,
			SDL_SCANCODE_SLEEP = 282,

			SDL_SCANCODE_APP1 = 283,
			SDL_SCANCODE_APP2 = 284,

			/* This is not a key, simply marks the number of scancodes
			 * so that you know how big to make your arrays. */
			SDL_NUM_SCANCODES = 512
}

		
		public enum SDL_Keycode
		{
			SDLK_UNKNOWN = 0,

			SDLK_RETURN = '\r',
			SDLK_ESCAPE = 27, // '\033'
			SDLK_BACKSPACE = '\b',
			SDLK_TAB = '\t',
			SDLK_SPACE = ' ',
			SDLK_EXCLAIM = '!',
			SDLK_QUOTEDBL = '"',
			SDLK_HASH = '#',
			SDLK_PERCENT = '%',
			SDLK_DOLLAR = '$',
			SDLK_AMPERSAND = '&',
			SDLK_QUOTE = '\'',
			SDLK_LEFTPAREN = '(',
			SDLK_RIGHTPAREN = ')',
			SDLK_ASTERISK = '*',
			SDLK_PLUS = '+',
			SDLK_COMMA = ',',
			SDLK_MINUS = '-',
			SDLK_PERIOD = '.',
			SDLK_SLASH = '/',
			SDLK_0 = '0',
			SDLK_1 = '1',
			SDLK_2 = '2',
			SDLK_3 = '3',
			SDLK_4 = '4',
			SDLK_5 = '5',
			SDLK_6 = '6',
			SDLK_7 = '7',
			SDLK_8 = '8',
			SDLK_9 = '9',
			SDLK_COLON = ':',
			SDLK_SEMICOLON = ';',
			SDLK_LESS = '<',
			SDLK_EQUALS = '=',
			SDLK_GREATER = '>',
			SDLK_QUESTION = '?',
			SDLK_AT = '@',
			/*
			Skip uppercase letters
			*/
			SDLK_LEFTBRACKET = '[',
			SDLK_BACKSLASH = '\\',
			SDLK_RIGHTBRACKET = ']',
			SDLK_CARET = '^',
			SDLK_UNDERSCORE = '_',
			SDLK_BACKQUOTE = '`',
			SDLK_a = 'a',
			SDLK_b = 'b',
			SDLK_c = 'c',
			SDLK_d = 'd',
			SDLK_e = 'e',
			SDLK_f = 'f',
			SDLK_g = 'g',
			SDLK_h = 'h',
			SDLK_i = 'i',
			SDLK_j = 'j',
			SDLK_k = 'k',
			SDLK_l = 'l',
			SDLK_m = 'm',
			SDLK_n = 'n',
			SDLK_o = 'o',
			SDLK_p = 'p',
			SDLK_q = 'q',
			SDLK_r = 'r',
			SDLK_s = 's',
			SDLK_t = 't',
			SDLK_u = 'u',
			SDLK_v = 'v',
			SDLK_w = 'w',
			SDLK_x = 'x',
			SDLK_y = 'y',
			SDLK_z = 'z',

			SDLK_CAPSLOCK = (int)SDL_Scancode.SDL_SCANCODE_CAPSLOCK | (1 << 30),

			SDLK_F1 = (int)SDL_Scancode.SDL_SCANCODE_F1 | (1 << 30),
			SDLK_F2 = (int)SDL_Scancode.SDL_SCANCODE_F2 | (1 << 30),
			SDLK_F3 = (int)SDL_Scancode.SDL_SCANCODE_F3 | (1 << 30),
			SDLK_F4 = (int)SDL_Scancode.SDL_SCANCODE_F4 | (1 << 30),
			SDLK_F5 = (int)SDL_Scancode.SDL_SCANCODE_F5 | (1 << 30),
			SDLK_F6 = (int)SDL_Scancode.SDL_SCANCODE_F6 | (1 << 30),
			SDLK_F7 = (int)SDL_Scancode.SDL_SCANCODE_F7 | (1 << 30),
			SDLK_F8 = (int)SDL_Scancode.SDL_SCANCODE_F8 | (1 << 30),
			SDLK_F9 = (int)SDL_Scancode.SDL_SCANCODE_F9 | (1 << 30),
			SDLK_F10 = (int)SDL_Scancode.SDL_SCANCODE_F10 | (1 << 30),
			SDLK_F11 = (int)SDL_Scancode.SDL_SCANCODE_F11 | (1 << 30),
			SDLK_F12 = (int)SDL_Scancode.SDL_SCANCODE_F12 | (1 << 30),

			SDLK_PRINTSCREEN = (int)SDL_Scancode.SDL_SCANCODE_PRINTSCREEN | (1 << 30),
			SDLK_SCROLLLOCK = (int)SDL_Scancode.SDL_SCANCODE_SCROLLLOCK | (1 << 30),
			SDLK_PAUSE = (int)SDL_Scancode.SDL_SCANCODE_PAUSE | (1 << 30),
			SDLK_INSERT = (int)SDL_Scancode.SDL_SCANCODE_INSERT | (1 << 30),
			SDLK_HOME = (int)SDL_Scancode.SDL_SCANCODE_HOME | (1 << 30),
			SDLK_PAGEUP = (int)SDL_Scancode.SDL_SCANCODE_PAGEUP | (1 << 30),
			SDLK_DELETE = 127,
			SDLK_END = (int)SDL_Scancode.SDL_SCANCODE_END | (1 << 30),
			SDLK_PAGEDOWN = (int)SDL_Scancode.SDL_SCANCODE_PAGEDOWN | (1 << 30),
			SDLK_RIGHT = (int)SDL_Scancode.SDL_SCANCODE_RIGHT | (1 << 30),
			SDLK_LEFT = (int)SDL_Scancode.SDL_SCANCODE_LEFT | (1 << 30),
			SDLK_DOWN = (int)SDL_Scancode.SDL_SCANCODE_DOWN | (1 << 30),
			SDLK_UP = (int)SDL_Scancode.SDL_SCANCODE_UP | (1 << 30),

			SDLK_NUMLOCKCLEAR = (int)SDL_Scancode.SDL_SCANCODE_NUMLOCKCLEAR | (1 << 30),
			SDLK_KP_DIVIDE = (int)SDL_Scancode.SDL_SCANCODE_KP_DIVIDE | (1 << 30),
			SDLK_KP_MULTIPLY = (int)SDL_Scancode.SDL_SCANCODE_KP_MULTIPLY | (1 << 30),
			SDLK_KP_MINUS = (int)SDL_Scancode.SDL_SCANCODE_KP_MINUS | (1 << 30),
			SDLK_KP_PLUS = (int)SDL_Scancode.SDL_SCANCODE_KP_PLUS | (1 << 30),
			SDLK_KP_ENTER = (int)SDL_Scancode.SDL_SCANCODE_KP_ENTER | (1 << 30),
			SDLK_KP_1 = (int)SDL_Scancode.SDL_SCANCODE_KP_1 | (1 << 30),
			SDLK_KP_2 = (int)SDL_Scancode.SDL_SCANCODE_KP_2 | (1 << 30),
			SDLK_KP_3 = (int)SDL_Scancode.SDL_SCANCODE_KP_3 | (1 << 30),
			SDLK_KP_4 = (int)SDL_Scancode.SDL_SCANCODE_KP_4 | (1 << 30),
			SDLK_KP_5 = (int)SDL_Scancode.SDL_SCANCODE_KP_5 | (1 << 30),
			SDLK_KP_6 = (int)SDL_Scancode.SDL_SCANCODE_KP_6 | (1 << 30),
			SDLK_KP_7 = (int)SDL_Scancode.SDL_SCANCODE_KP_7 | (1 << 30),
			SDLK_KP_8 = (int)SDL_Scancode.SDL_SCANCODE_KP_8 | (1 << 30),
			SDLK_KP_9 = (int)SDL_Scancode.SDL_SCANCODE_KP_9 | (1 << 30),
			SDLK_KP_0 = (int)SDL_Scancode.SDL_SCANCODE_KP_0 | (1 << 30),
			SDLK_KP_PERIOD = (int)SDL_Scancode.SDL_SCANCODE_KP_PERIOD | (1 << 30),

			SDLK_APPLICATION = (int)SDL_Scancode.SDL_SCANCODE_APPLICATION | (1 << 30),
			SDLK_POWER = (int)SDL_Scancode.SDL_SCANCODE_POWER | (1 << 30),
			SDLK_KP_EQUALS = (int)SDL_Scancode.SDL_SCANCODE_KP_EQUALS | (1 << 30),
			SDLK_F13 = (int)SDL_Scancode.SDL_SCANCODE_F13 | (1 << 30),
			SDLK_F14 = (int)SDL_Scancode.SDL_SCANCODE_F14 | (1 << 30),
			SDLK_F15 = (int)SDL_Scancode.SDL_SCANCODE_F15 | (1 << 30),
			SDLK_F16 = (int)SDL_Scancode.SDL_SCANCODE_F16 | (1 << 30),
			SDLK_F17 = (int)SDL_Scancode.SDL_SCANCODE_F17 | (1 << 30),
			SDLK_F18 = (int)SDL_Scancode.SDL_SCANCODE_F18 | (1 << 30),
			SDLK_F19 = (int)SDL_Scancode.SDL_SCANCODE_F19 | (1 << 30),
			SDLK_F20 = (int)SDL_Scancode.SDL_SCANCODE_F20 | (1 << 30),
			SDLK_F21 = (int)SDL_Scancode.SDL_SCANCODE_F21 | (1 << 30),
			SDLK_F22 = (int)SDL_Scancode.SDL_SCANCODE_F22 | (1 << 30),
			SDLK_F23 = (int)SDL_Scancode.SDL_SCANCODE_F23 | (1 << 30),
			SDLK_F24 = (int)SDL_Scancode.SDL_SCANCODE_F24 | (1 << 30),
			SDLK_EXECUTE = (int)SDL_Scancode.SDL_SCANCODE_EXECUTE | (1 << 30),
			SDLK_HELP = (int)SDL_Scancode.SDL_SCANCODE_HELP | (1 << 30),
			SDLK_MENU = (int)SDL_Scancode.SDL_SCANCODE_MENU | (1 << 30),
			SDLK_SELECT = (int)SDL_Scancode.SDL_SCANCODE_SELECT | (1 << 30),
			SDLK_STOP = (int)SDL_Scancode.SDL_SCANCODE_STOP | (1 << 30),
			SDLK_AGAIN = (int)SDL_Scancode.SDL_SCANCODE_AGAIN | (1 << 30),
			SDLK_UNDO = (int)SDL_Scancode.SDL_SCANCODE_UNDO | (1 << 30),
			SDLK_CUT = (int)SDL_Scancode.SDL_SCANCODE_CUT | (1 << 30),
			SDLK_COPY = (int)SDL_Scancode.SDL_SCANCODE_COPY | (1 << 30),
			SDLK_PASTE = (int)SDL_Scancode.SDL_SCANCODE_PASTE | (1 << 30),
			SDLK_FIND = (int)SDL_Scancode.SDL_SCANCODE_FIND | (1 << 30),
			SDLK_MUTE = (int)SDL_Scancode.SDL_SCANCODE_MUTE | (1 << 30),
			SDLK_VOLUMEUP = (int)SDL_Scancode.SDL_SCANCODE_VOLUMEUP | (1 << 30),
			SDLK_VOLUMEDOWN = (int)SDL_Scancode.SDL_SCANCODE_VOLUMEDOWN | (1 << 30),
			SDLK_KP_COMMA = (int)SDL_Scancode.SDL_SCANCODE_KP_COMMA | (1 << 30),
			SDLK_KP_EQUALSAS400 =
			(int)SDL_Scancode.SDL_SCANCODE_KP_EQUALSAS400 | (1 << 30),

			SDLK_ALTERASE = (int)SDL_Scancode.SDL_SCANCODE_ALTERASE | (1 << 30),
			SDLK_SYSREQ = (int)SDL_Scancode.SDL_SCANCODE_SYSREQ | (1 << 30),
			SDLK_CANCEL = (int)SDL_Scancode.SDL_SCANCODE_CANCEL | (1 << 30),
			SDLK_CLEAR = (int)SDL_Scancode.SDL_SCANCODE_CLEAR | (1 << 30),
			SDLK_PRIOR = (int)SDL_Scancode.SDL_SCANCODE_PRIOR | (1 << 30),
			SDLK_RETURN2 = (int)SDL_Scancode.SDL_SCANCODE_RETURN2 | (1 << 30),
			SDLK_SEPARATOR = (int)SDL_Scancode.SDL_SCANCODE_SEPARATOR | (1 << 30),
			SDLK_OUT = (int)SDL_Scancode.SDL_SCANCODE_OUT | (1 << 30),
			SDLK_OPER = (int)SDL_Scancode.SDL_SCANCODE_OPER | (1 << 30),
			SDLK_CLEARAGAIN = (int)SDL_Scancode.SDL_SCANCODE_CLEARAGAIN | (1 << 30),
			SDLK_CRSEL = (int)SDL_Scancode.SDL_SCANCODE_CRSEL | (1 << 30),
			SDLK_EXSEL = (int)SDL_Scancode.SDL_SCANCODE_EXSEL | (1 << 30),

			SDLK_KP_00 = (int)SDL_Scancode.SDL_SCANCODE_KP_00 | (1 << 30),
			SDLK_KP_000 = (int)SDL_Scancode.SDL_SCANCODE_KP_000 | (1 << 30),
			SDLK_THOUSANDSSEPARATOR =
			(int)SDL_Scancode.SDL_SCANCODE_THOUSANDSSEPARATOR | (1 << 30),
			SDLK_DECIMALSEPARATOR =
			(int)SDL_Scancode.SDL_SCANCODE_DECIMALSEPARATOR | (1 << 30),
			SDLK_CURRENCYUNIT = (int)SDL_Scancode.SDL_SCANCODE_CURRENCYUNIT | (1 << 30),
			SDLK_CURRENCYSUBUNIT =
			(int)SDL_Scancode.SDL_SCANCODE_CURRENCYSUBUNIT | (1 << 30),
			SDLK_KP_LEFTPAREN = (int)SDL_Scancode.SDL_SCANCODE_KP_LEFTPAREN | (1 << 30),
			SDLK_KP_RIGHTPAREN = (int)SDL_Scancode.SDL_SCANCODE_KP_RIGHTPAREN | (1 << 30),
			SDLK_KP_LEFTBRACE = (int)SDL_Scancode.SDL_SCANCODE_KP_LEFTBRACE | (1 << 30),
			SDLK_KP_RIGHTBRACE = (int)SDL_Scancode.SDL_SCANCODE_KP_RIGHTBRACE | (1 << 30),
			SDLK_KP_TAB = (int)SDL_Scancode.SDL_SCANCODE_KP_TAB | (1 << 30),
			SDLK_KP_BACKSPACE = (int)SDL_Scancode.SDL_SCANCODE_KP_BACKSPACE | (1 << 30),
			SDLK_KP_A = (int)SDL_Scancode.SDL_SCANCODE_KP_A | (1 << 30),
			SDLK_KP_B = (int)SDL_Scancode.SDL_SCANCODE_KP_B | (1 << 30),
			SDLK_KP_C = (int)SDL_Scancode.SDL_SCANCODE_KP_C | (1 << 30),
			SDLK_KP_D = (int)SDL_Scancode.SDL_SCANCODE_KP_D | (1 << 30),
			SDLK_KP_E = (int)SDL_Scancode.SDL_SCANCODE_KP_E | (1 << 30),
			SDLK_KP_F = (int)SDL_Scancode.SDL_SCANCODE_KP_F | (1 << 30),
			SDLK_KP_XOR = (int)SDL_Scancode.SDL_SCANCODE_KP_XOR | (1 << 30),
			SDLK_KP_POWER = (int)SDL_Scancode.SDL_SCANCODE_KP_POWER | (1 << 30),
			SDLK_KP_PERCENT = (int)SDL_Scancode.SDL_SCANCODE_KP_PERCENT | (1 << 30),
			SDLK_KP_LESS = (int)SDL_Scancode.SDL_SCANCODE_KP_LESS | (1 << 30),
			SDLK_KP_GREATER = (int)SDL_Scancode.SDL_SCANCODE_KP_GREATER | (1 << 30),
			SDLK_KP_AMPERSAND = (int)SDL_Scancode.SDL_SCANCODE_KP_AMPERSAND | (1 << 30),
			SDLK_KP_DBLAMPERSAND =
			(int)SDL_Scancode.SDL_SCANCODE_KP_DBLAMPERSAND | (1 << 30),
			SDLK_KP_VERTICALBAR =
			(int)SDL_Scancode.SDL_SCANCODE_KP_VERTICALBAR | (1 << 30),
			SDLK_KP_DBLVERTICALBAR =
			(int)SDL_Scancode.SDL_SCANCODE_KP_DBLVERTICALBAR | (1 << 30),
			SDLK_KP_COLON = (int)SDL_Scancode.SDL_SCANCODE_KP_COLON | (1 << 30),
			SDLK_KP_HASH = (int)SDL_Scancode.SDL_SCANCODE_KP_HASH | (1 << 30),
			SDLK_KP_SPACE = (int)SDL_Scancode.SDL_SCANCODE_KP_SPACE | (1 << 30),
			SDLK_KP_AT = (int)SDL_Scancode.SDL_SCANCODE_KP_AT | (1 << 30),
			SDLK_KP_EXCLAM = (int)SDL_Scancode.SDL_SCANCODE_KP_EXCLAM | (1 << 30),
			SDLK_KP_MEMSTORE = (int)SDL_Scancode.SDL_SCANCODE_KP_MEMSTORE | (1 << 30),
			SDLK_KP_MEMRECALL = (int)SDL_Scancode.SDL_SCANCODE_KP_MEMRECALL | (1 << 30),
			SDLK_KP_MEMCLEAR = (int)SDL_Scancode.SDL_SCANCODE_KP_MEMCLEAR | (1 << 30),
			SDLK_KP_MEMADD = (int)SDL_Scancode.SDL_SCANCODE_KP_MEMADD | (1 << 30),
			SDLK_KP_MEMSUBTRACT =
			(int)SDL_Scancode.SDL_SCANCODE_KP_MEMSUBTRACT | (1 << 30),
			SDLK_KP_MEMMULTIPLY =
			(int)SDL_Scancode.SDL_SCANCODE_KP_MEMMULTIPLY | (1 << 30),
			SDLK_KP_MEMDIVIDE = (int)SDL_Scancode.SDL_SCANCODE_KP_MEMDIVIDE | (1 << 30),
			SDLK_KP_PLUSMINUS = (int)SDL_Scancode.SDL_SCANCODE_KP_PLUSMINUS | (1 << 30),
			SDLK_KP_CLEAR = (int)SDL_Scancode.SDL_SCANCODE_KP_CLEAR | (1 << 30),
			SDLK_KP_CLEARENTRY = (int)SDL_Scancode.SDL_SCANCODE_KP_CLEARENTRY | (1 << 30),
			SDLK_KP_BINARY = (int)SDL_Scancode.SDL_SCANCODE_KP_BINARY | (1 << 30),
			SDLK_KP_OCTAL = (int)SDL_Scancode.SDL_SCANCODE_KP_OCTAL | (1 << 30),
			SDLK_KP_DECIMAL = (int)SDL_Scancode.SDL_SCANCODE_KP_DECIMAL | (1 << 30),
			SDLK_KP_HEXADECIMAL =
			(int)SDL_Scancode.SDL_SCANCODE_KP_HEXADECIMAL | (1 << 30),

			SDLK_LCTRL = (int)SDL_Scancode.SDL_SCANCODE_LCTRL | (1 << 30),
			SDLK_LSHIFT = (int)SDL_Scancode.SDL_SCANCODE_LSHIFT | (1 << 30),
			SDLK_LALT = (int)SDL_Scancode.SDL_SCANCODE_LALT | (1 << 30),
			SDLK_LGUI = (int)SDL_Scancode.SDL_SCANCODE_LGUI | (1 << 30),
			SDLK_RCTRL = (int)SDL_Scancode.SDL_SCANCODE_RCTRL | (1 << 30),
			SDLK_RSHIFT = (int)SDL_Scancode.SDL_SCANCODE_RSHIFT | (1 << 30),
			SDLK_RALT = (int)SDL_Scancode.SDL_SCANCODE_RALT | (1 << 30),
			SDLK_RGUI = (int)SDL_Scancode.SDL_SCANCODE_RGUI | (1 << 30),

			SDLK_MODE = (int)SDL_Scancode.SDL_SCANCODE_MODE | (1 << 30),

			SDLK_AUDIONEXT = (int)SDL_Scancode.SDL_SCANCODE_AUDIONEXT | (1 << 30),
			SDLK_AUDIOPREV = (int)SDL_Scancode.SDL_SCANCODE_AUDIOPREV | (1 << 30),
			SDLK_AUDIOSTOP = (int)SDL_Scancode.SDL_SCANCODE_AUDIOSTOP | (1 << 30),
			SDLK_AUDIOPLAY = (int)SDL_Scancode.SDL_SCANCODE_AUDIOPLAY | (1 << 30),
			SDLK_AUDIOMUTE = (int)SDL_Scancode.SDL_SCANCODE_AUDIOMUTE | (1 << 30),
			SDLK_MEDIASELECT = (int)SDL_Scancode.SDL_SCANCODE_MEDIASELECT | (1 << 30),
			SDLK_WWW = (int)SDL_Scancode.SDL_SCANCODE_WWW | (1 << 30),
			SDLK_MAIL = (int)SDL_Scancode.SDL_SCANCODE_MAIL | (1 << 30),
			SDLK_CALCULATOR = (int)SDL_Scancode.SDL_SCANCODE_CALCULATOR | (1 << 30),
			SDLK_COMPUTER = (int)SDL_Scancode.SDL_SCANCODE_COMPUTER | (1 << 30),
			SDLK_AC_SEARCH = (int)SDL_Scancode.SDL_SCANCODE_AC_SEARCH | (1 << 30),
			SDLK_AC_HOME = (int)SDL_Scancode.SDL_SCANCODE_AC_HOME | (1 << 30),
			SDLK_AC_BACK = (int)SDL_Scancode.SDL_SCANCODE_AC_BACK | (1 << 30),
			SDLK_AC_FORWARD = (int)SDL_Scancode.SDL_SCANCODE_AC_FORWARD | (1 << 30),
			SDLK_AC_STOP = (int)SDL_Scancode.SDL_SCANCODE_AC_STOP | (1 << 30),
			SDLK_AC_REFRESH = (int)SDL_Scancode.SDL_SCANCODE_AC_REFRESH | (1 << 30),
			SDLK_AC_BOOKMARKS = (int)SDL_Scancode.SDL_SCANCODE_AC_BOOKMARKS | (1 << 30),

			SDLK_BRIGHTNESSDOWN =
			(int)SDL_Scancode.SDL_SCANCODE_BRIGHTNESSDOWN | (1 << 30),
			SDLK_BRIGHTNESSUP = (int)SDL_Scancode.SDL_SCANCODE_BRIGHTNESSUP | (1 << 30),
			SDLK_DISPLAYSWITCH = (int)SDL_Scancode.SDL_SCANCODE_DISPLAYSWITCH | (1 << 30),
			SDLK_KBDILLUMTOGGLE =
			(int)SDL_Scancode.SDL_SCANCODE_KBDILLUMTOGGLE | (1 << 30),
			SDLK_KBDILLUMDOWN = (int)SDL_Scancode.SDL_SCANCODE_KBDILLUMDOWN | (1 << 30),
			SDLK_KBDILLUMUP = (int)SDL_Scancode.SDL_SCANCODE_KBDILLUMUP | (1 << 30),
			SDLK_EJECT = (int)SDL_Scancode.SDL_SCANCODE_EJECT | (1 << 30),
			SDLK_SLEEP = (int)SDL_Scancode.SDL_SCANCODE_SLEEP | (1 << 30)
}


       
        public unsafe struct SDL_Surface
        {
            public uint flags;               /**< Read-only */
            public void* format;    /**< Read-only */
            public int w, h;                   /**< Read-only */
            public int pitch;                  /**< Read-only */
            public void* pixels;               /**< Read-write */

            /** Application data associated with the surface */
            public void* userdata;             /**< Read-write */

            /** information needed for surfaces requiring locks */
            public int locked;                 /**< Read-only */
            public void* lock_data;            /**< Read-only */

            /** clipping information */
            public SDL_Rect clip_rect;         /**< Read-only */

            /** info for fast blit mapping to other surfaces */
            public void* map;    /**< Private */

            /** Reference count -- used when freeing surface */
            public int refcount;               /**< Read-mostly */
        }

        public struct SDL_Rect
        {
            public int x, y;
            public int w, h;
        }


        [Flags]
        public enum SDL_RendererFlags
        {
            SDL_RENDERER_SOFTWARE = 0x00000001,         /**< The renderer is a software fallback */
            SDL_RENDERER_ACCELERATED = 0x00000002,      /**< The renderer uses hardware
                                                     acceleration */
            SDL_RENDERER_PRESENTVSYNC = 0x00000004,     /**< Present is synchronized
                                                     with the refresh rate */
            SDL_RENDERER_TARGETTEXTURE = 0x00000008     /**< The renderer supports
                                                     rendering to texture */
        }

        public enum SdlInit
        {
            SDL_INIT_VIDEO = 0x00000020
        }

        [Flags]
        public enum SDL_WindowFlags
        {
            SDL_WINDOW_FULLSCREEN = 0x00000001,         /**< fullscreen window */
            SDL_WINDOW_OPENGL = 0x00000002,             /**< window usable with OpenGL context */
            SDL_WINDOW_SHOWN = 0x00000004,              /**< window is visible */
            SDL_WINDOW_HIDDEN = 0x00000008,             /**< window is not visible */
            SDL_WINDOW_BORDERLESS = 0x00000010,         /**< no window decoration */
            SDL_WINDOW_RESIZABLE = 0x00000020,          /**< window can be resized */
            SDL_WINDOW_MINIMIZED = 0x00000040,          /**< window is minimized */
            SDL_WINDOW_MAXIMIZED = 0x00000080,          /**< window is maximized */
            SDL_WINDOW_INPUT_GRABBED = 0x00000100,      /**< window has grabbed input focus */
            SDL_WINDOW_INPUT_FOCUS = 0x00000200,        /**< window has input focus */
            SDL_WINDOW_MOUSE_FOCUS = 0x00000400,        /**< window has mouse focus */
            SDL_WINDOW_FULLSCREEN_DESKTOP = (SDL_WINDOW_FULLSCREEN | 0x00001000),
            SDL_WINDOW_FOREIGN = 0x00000800,            /**< window not created by SDL */
            SDL_WINDOW_ALLOW_HIGHDPI = 0x00002000,      /**< window should be created in high-DPI mode if supported */
            SDL_WINDOW_MOUSE_CAPTURE = 0x00004000       /**< window has mouse captured (unrelated to INPUT_GRABBED) */
        }

        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public unsafe class SDL_Event
        {
            [FieldOffset(0)]
            public uint type;
        }

        public enum SDL_EventType
        {
            SDL_FIRSTEVENT = 0,     /**< Unused (do not remove) */

            /* Application events */
            SDL_QUIT = 0x100, /**< User-requested quit */

            /* These application events have special meaning on iOS, see README-ios.md for details */
            SDL_APP_TERMINATING,        /**< The application is being terminated by the OS
                                     Called on iOS in applicationWillTerminate()
                                     Called on Android in onDestroy()
                                */
            SDL_APP_LOWMEMORY,          /**< The application is low on memory, free memory if possible.
                                     Called on iOS in applicationDidReceiveMemoryWarning()
                                     Called on Android in onLowMemory()
                                */
            SDL_APP_WILLENTERBACKGROUND, /**< The application is about to enter the background
                                     Called on iOS in applicationWillResignActive()
                                     Called on Android in onPause()
                                */
            SDL_APP_DIDENTERBACKGROUND, /**< The application did enter the background and may not get CPU for some time
                                     Called on iOS in applicationDidEnterBackground()
                                     Called on Android in onPause()
                                */
            SDL_APP_WILLENTERFOREGROUND, /**< The application is about to enter the foreground
                                     Called on iOS in applicationWillEnterForeground()
                                     Called on Android in onResume()
                                */
            SDL_APP_DIDENTERFOREGROUND, /**< The application is now interactive
                                     Called on iOS in applicationDidBecomeActive()
                                     Called on Android in onResume()
                                */

            /* Window events */
            SDL_WINDOWEVENT = 0x200, /**< Window state change */
            SDL_SYSWMEVENT,             /**< System specific event */

            /* Keyboard events */
            SDL_KEYDOWN = 0x300, /**< Key pressed */
            SDL_KEYUP,                  /**< Key released */
            SDL_TEXTEDITING,            /**< Keyboard text editing (composition) */
            SDL_TEXTINPUT,              /**< Keyboard text input */
            SDL_KEYMAPCHANGED,          /**< Keymap changed due to a system event such as an
                                     input language or keyboard layout change.
                                */

            /* Mouse events */
            SDL_MOUSEMOTION = 0x400, /**< Mouse moved */
            SDL_MOUSEBUTTONDOWN,        /**< Mouse button pressed */
            SDL_MOUSEBUTTONUP,          /**< Mouse button released */
            SDL_MOUSEWHEEL,             /**< Mouse wheel motion */

            /* Joystick events */
            SDL_JOYAXISMOTION = 0x600, /**< Joystick axis motion */
            SDL_JOYBALLMOTION,          /**< Joystick trackball motion */
            SDL_JOYHATMOTION,           /**< Joystick hat position change */
            SDL_JOYBUTTONDOWN,          /**< Joystick button pressed */
            SDL_JOYBUTTONUP,            /**< Joystick button released */
            SDL_JOYDEVICEADDED,         /**< A new joystick has been inserted into the system */
            SDL_JOYDEVICEREMOVED,       /**< An opened joystick has been removed */

            /* Game controller events */
            SDL_CONTROLLERAXISMOTION = 0x650, /**< Game controller axis motion */
            SDL_CONTROLLERBUTTONDOWN,          /**< Game controller button pressed */
            SDL_CONTROLLERBUTTONUP,            /**< Game controller button released */
            SDL_CONTROLLERDEVICEADDED,         /**< A new Game controller has been inserted into the system */
            SDL_CONTROLLERDEVICEREMOVED,       /**< An opened Game controller has been removed */
            SDL_CONTROLLERDEVICEREMAPPED,      /**< The controller mapping was updated */

            /* Touch events */
            SDL_FINGERDOWN = 0x700,
            SDL_FINGERUP,
            SDL_FINGERMOTION,

            /* Gesture events */
            SDL_DOLLARGESTURE = 0x800,
            SDL_DOLLARRECORD,
            SDL_MULTIGESTURE,

            /* Clipboard events */
            SDL_CLIPBOARDUPDATE = 0x900, /**< The clipboard changed */

            /* Drag and drop events */
            SDL_DROPFILE = 0x1000, /**< The system requests a file open */

            /* Audio hotplug events */
            SDL_AUDIODEVICEADDED = 0x1100, /**< A new audio device is available */
            SDL_AUDIODEVICEREMOVED,        /**< An audio device has been removed. */

            /* Render events */
            SDL_RENDER_TARGETS_RESET = 0x2000, /**< The render targets have been reset and their contents need to be updated */
            SDL_RENDER_DEVICE_RESET, /**< The device has been reset and all textures need to be recreated */

            /** Events ::SDL_USEREVENT through ::SDL_LASTEVENT are for your use,
             *  and should be allocated with SDL_RegisterEvents()
             */
            SDL_USEREVENT = 0x8000,

            /**
             *  This last event is only for bounding internal arrays
             */
            SDL_LASTEVENT = 0xFFFF
        }

        unsafe struct SDL_Window
        {
            void* magic;
            uint id;
            string title;
            void* icon;
            int x, y;
            int w, h;
            int min_w, min_h;
            int max_w, max_h;
            uint flags;
            uint last_fullscreen_flags;

            /* Stored position and size for windowed mode */
            void* windowed;

            void* fullscreen_mode;

            float brightness;
            UInt16* gamma;
            UInt16* saved_gamma;        /* (just offset into gamma) */

            void* surface;
            void* surface_valid;

            void* is_hiding;
            void* is_destroying;
            void* shaper;

            void* hit_test;
            void* hit_test_data;

            void* data;

            void* driverdata;

            void* prev;
            void* next;
        };



}