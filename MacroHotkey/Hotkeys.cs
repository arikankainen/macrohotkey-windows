using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MacroHotkey
{
    public static class Hotkeys
    {
        public static int GetGlobalHotkeyModNumber(string keyname)
        {
            int i = 0;
            if (keyname.IndexOf("Alt") != -1) i += 1;
            if (keyname.IndexOf("Ctrl") != -1) i += 2;
            if (keyname.IndexOf("Control") != -1) i += 2;
            if (keyname.IndexOf("Shift") != -1) i += 4;
            if (keyname.IndexOf("Win") != -1) i += 8;
            return i;
        }

        public static string GetSendkeyModChars(string keyname)
        {
            string i = null;
            if (keyname.IndexOf("Alt") != -1) i += "%";
            if (keyname.IndexOf("Ctrl") != -1) i += "^";
            if (keyname.IndexOf("Control") != -1) i += "^";
            if (keyname.IndexOf("Shift") != -1) i += "+";
            return i;
        }

        public static string GetSendkeyChar(string i)
        {
            if (i == "D1") i = "1";
            if (i == "D2") i = "2";
            if (i == "D3") i = "3";
            if (i == "D4") i = "4";
            if (i == "D5") i = "5";
            if (i == "D6") i = "6";
            if (i == "D7") i = "7";
            if (i == "D8") i = "8";
            if (i == "D9") i = "9";
            if (i == "D0") i = "0";
            return i.ToLower();
        }

        public static string GetHotkeyModifiers(string keys)
        {
            string mod = null;
            bool first = true;

            if (keys.IndexOf("Shift") != -1)
            {
                if (!first) mod += ", ";
                mod += "Shift";
                first = false;
            }

            if (keys.IndexOf("Ctrl") != -1)
            {
                if (!first) mod += ", ";
                mod += "Control";
                first = false;
            }

            if (keys.IndexOf("Alt") != -1)
            {
                if (!first) mod += ", ";
                mod += "Alt";
                first = false;
            }

            return mod;
        }

        public static string GetHotkeyModifiersGlobal(string keys)
        {
            string mod = null;
            bool first = true;

            if (keys.IndexOf("Alt") != -1)
            {
                if (!first) mod += ", ";
                mod += "Alt";
                first = false;
            }

            if (keys.IndexOf("Ctrl") != -1)
            {
                if (!first) mod += ", ";
                mod += "Control";
                first = false;
            }

            if (keys.IndexOf("Shift") != -1)
            {
                if (!first) mod += ", ";
                mod += "Shift";
                first = false;
            }

            return mod;
        }

        public static string GetHotkeyKey(string keys)
        {
            return keys.Replace("Shift", "").Replace("Ctrl", "").Replace("Alt", "").Replace("+", "");
        }

        public static string ValueListToKeyList(string value)
        {
            if (value != "")
            {
                List<string> hotkeyList = value.Split('|').ToList<string>();
                bool first = true;
                string hotkey = "";

                foreach (string key in hotkeyList)
                {
                    if (first)
                    {
                        hotkey = GetKeyName(key);
                        first = false;
                    }
                    else hotkey += "+" + GetKeyName(key);
                }

                return hotkey;
            }
            return "";

        }

        public static string KeyListToValueList(string value)
        {
            if (value != "")
            {
                List<string> hotkeyList = value.Split('+').ToList<string>();
                bool first = true;
                string hotkey = "";

                foreach (string key in hotkeyList)
                {
                    if (first)
                    {
                        hotkey = GetValue(key);
                        first = false;
                    }
                    else hotkey += "|" + GetValue(key);
                }

                return hotkey;
            }
            return "";

        }

        public static string GetKeyName(string keyValue)
        {
            string keyString;

            switch (keyValue)
            {
                case "8":
                    keyString = "Backspace";
                    break;
                case "13":
                    keyString = "Enter";
                    break;
                case "16":
                    keyString = "Shift";
                    break;
                case "17":
                    keyString = "Ctrl";
                    break;
                case "18":
                    keyString = "Alt";
                    break;
                case "20":
                    keyString = "CapsLock";
                    break;
                case "27":
                    keyString = "Esc";
                    break;
                case "34":
                    keyString = "PageDown";
                    break;
                case "48":
                    keyString = "0";
                    break;
                case "49":
                    keyString = "1";
                    break;
                case "50":
                    keyString = "2";
                    break;
                case "51":
                    keyString = "3";
                    break;
                case "52":
                    keyString = "4";
                    break;
                case "53":
                    keyString = "5";
                    break;
                case "54":
                    keyString = "6";
                    break;
                case "55":
                    keyString = "7";
                    break;
                case "56":
                    keyString = "8";
                    break;
                case "57":
                    keyString = "9";
                    break;
                case "186":
                    keyString = "¨";
                    break;
                case "187":
                    keyString = "Plus";
                    break;
                case "188":
                    keyString = ",";
                    break;
                case "189":
                    keyString = "Minus";
                    break;
                case "190":
                    keyString = ".";
                    break;
                case "191":
                    keyString = "'";
                    break;
                case "192":
                    keyString = "Ö";
                    break;
                case "219":
                    keyString = "´";
                    break;
                case "220":
                    keyString = "§";
                    break;
                case "221":
                    keyString = "Å";
                    break;
                case "222":
                    keyString = "Ä";
                    break;
                case "226":
                    keyString = "<";
                    break;
                default:
                    keyString = ((Keys)Enum.Parse(typeof(Keys), keyValue)).ToString();
                    break;
            }

            return keyString;
        }

        public static string GetValue(string keyString)
        {
            string keyValue;

            switch (keyString)
            {
                case "Backspace":
                    keyValue = "8";
                    break;
                case "Enter":
                    keyValue = "13";
                    break;
                case "Shift":
                    keyValue = "16";
                    break;
                case "Ctrl":
                    keyValue = "17";
                    break;
                case "Alt":
                    keyValue = "18";
                    break;
                case "CapsLock":
                    keyValue = "20";
                    break;
                case "Esc":
                    keyValue = "27";
                    break;
                case "PageDown":
                    keyValue = "34";
                    break;
                case "0":
                    keyValue = "48";
                    break;
                case "1":
                    keyValue = "49";
                    break;
                case "2":
                    keyValue = "50";
                    break;
                case "3":
                    keyValue = "51";
                    break;
                case "4":
                    keyValue = "52";
                    break;
                case "5":
                    keyValue = "53";
                    break;
                case "6":
                    keyValue = "54";
                    break;
                case "7":
                    keyValue = "55";
                    break;
                case "8":
                    keyValue = "56";
                    break;
                case "9":
                    keyValue = "57";
                    break;
                case "¨":
                    keyValue = "186";
                    break;
                case "Plus":
                    keyValue = "187";
                    break;
                case ",":
                    keyValue = "188";
                    break;
                case "Minus":
                    keyValue = "189";
                    break;
                case ".":
                    keyValue = "190";
                    break;
                case "'":
                    keyValue = "191";
                    break;
                case "Ö":
                    keyValue = "192";
                    break;
                case "´":
                    keyValue = "219";
                    break;
                case "§":
                    keyValue = "220";
                    break;
                case "Å":
                    keyValue = "221";
                    break;
                case "Ä":
                    keyValue = "222";
                    break;
                case "<":
                    keyValue = "226";
                    break;
                default:
                    keyValue = ((int)Enum.Parse(typeof(Keys), keyString, true)).ToString();
                    break;
            }

            return keyValue;
        }

        public static string GetKeyNameSendKey(string keyValue)
        {
            string keyString = ((Keys)Enum.Parse(typeof(Keys), keyValue)).ToString();

            switch (keyValue)
            {
                case "16":
                    keyString = "+";
                    break;
                case "17":
                    keyString = "^";
                    break;
                case "18":
                    keyString = "%";
                    break;
            }

            return keyString;
        }


    }
}
