﻿using UnityEngine;
using Verse;
using System;

namespace CommonSense
{
    public class Settings : ModSettings
    {
        public static bool separate_meals = true;
        public static bool fulfill_outdoors = true;
        public static bool odd_is_normal = false;
        public static bool clean_before_work = true;
        public static bool clean_after_tanding = true;
        public static bool calculate_full_path = true;
        public static bool add_meal_ingredients = false;

        public static void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listing_Standard = new Listing_Standard();
            listing_Standard.Begin(inRect);
            listing_Standard.Label("fulfill_outdoors_head".Translate());
            listing_Standard.CheckboxLabeled("fulfill_outdoors_label".Translate(), ref fulfill_outdoors, "fulfill_outdoors_note".Translate());
            listing_Standard.GapLine();
            listing_Standard.Label("clean_head".Translate());
            listing_Standard.CheckboxLabeled("clean_before_working_label".Translate(), ref clean_before_work, "clean_before_working_note".Translate());
            listing_Standard.CheckboxLabeled("bill_job_pathing_label".Translate(), ref calculate_full_path, "bill_job_pathing_note".Translate());
            listing_Standard.CheckboxLabeled("clean_after_tending_label".Translate(), ref clean_after_tanding, "clean_after_tending_note".Translate());
            listing_Standard.GapLine();
            listing_Standard.Label("meal_stacking_head".Translate());
            listing_Standard.CheckboxLabeled("meal_stacking_label".Translate(), ref separate_meals, "meal_stacking_note".Translate());
            listing_Standard.CheckboxLabeled("dont_count_odd_label".Translate(), ref odd_is_normal, "dont_count_odd_note".Translate());
            listing_Standard.GapLine();
            listing_Standard.Label("gen_ingredients_head".Translate());
            listing_Standard.CheckboxLabeled("gen_ingredients_label".Translate(), ref add_meal_ingredients, "gen_ingredients_note".Translate());
            listing_Standard.End();
        }

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look<bool>(ref separate_meals, "separate_meals", true, false);
            Scribe_Values.Look<bool>(ref fulfill_outdoors, "fulfill_outdoors", true, false);
            Scribe_Values.Look<bool>(ref odd_is_normal, "odd_is_normal", false, false);
            Scribe_Values.Look<bool>(ref clean_before_work, "clean_before_work", true, false);
            Scribe_Values.Look<bool>(ref clean_after_tanding, "clean_after_tanding", true, false);
            Scribe_Values.Look<bool>(ref calculate_full_path, "calculate_full_path", true, false);
            Scribe_Values.Look<bool>(ref add_meal_ingredients, "add_meal_ingredients", false, false);
        }
    }
}