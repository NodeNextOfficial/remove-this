using HarmonyLib;
using System.Reflection;
using Verse;

namespace ThatCodyGuy.RemoveThis {
    [StaticConstructorOnStartup]
    public class RemoveTutorialButton {
        static RemoveTutorialButton() {
            var harmony = new Harmony("ThatCodyGuy.RemoveThis");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
