
namespace Kethane
{
    public class KethaneMapViewer : PartModule
    {
        [KSPEvent(guiActive = true, guiName = "Show Map", active = true)]
        public void ShowMap()
        {
            KethaneController.GetInstance(this.vessel).ShowDetectorWindow = true;
        }

        [KSPEvent(guiActive = true, guiName = "Hide Map", active = false)]
        public void HideMap()
        {
            KethaneController.GetInstance(this.vessel).ShowDetectorWindow = false;
        }

        public override void OnUpdate()
        {
            var controller = KethaneController.GetInstance(this.vessel);
            Events["ShowMap"].active = !controller.ShowDetectorWindow;
            Events["HideMap"].active = controller.ShowDetectorWindow;
        }
    }
}
