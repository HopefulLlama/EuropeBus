using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{

    class WindowsHandler
    {
        private static WindowsHandler instance = new WindowsHandler();

        DataManager dataManager = new DataManager();
        public DataManager getDataManager()
        {
            if (dataManager.IsDisposed)
            {
                dataManager = new DataManager();
            }
            return dataManager;
        }

        JourneyAdd journeyAdd = new JourneyAdd();
        public JourneyAdd getJourneyAdd()
        {
            if (journeyAdd.IsDisposed)
            {
                journeyAdd = new JourneyAdd();
            }
            return journeyAdd;
        }

        JourneyEdit journeyEdit = new JourneyEdit();
        public JourneyEdit getJourneyEdit()
        {
            if (journeyEdit.IsDisposed)
            {
                journeyEdit = new JourneyEdit();
            }
            return journeyEdit;
        }

        JourneyManager journeyManager = new JourneyManager();
        public JourneyManager getJourneyManager()
        {
            if (journeyManager.IsDisposed)
            {
                journeyManager = new JourneyManager();
            }
            return journeyManager;
        }

        MainMenu mainMenu = new MainMenu();
        public MainMenu getMainMenu()
        {
            if (mainMenu.IsDisposed)
            {
                mainMenu = new MainMenu();
            }
            return mainMenu;
        }

        RouteAdd routeAdd = new RouteAdd();
        public RouteAdd getRouteAdd()
        {
            if (routeAdd.IsDisposed)
            {
                routeAdd = new RouteAdd();
            }
            return routeAdd;
        }

        RouteEdit routeEdit = new RouteEdit();
        public RouteEdit getRouteEdit()
        {
            if (routeEdit.IsDisposed)
            {
                routeEdit = new RouteEdit();
            }
            return routeEdit;
        }

        RouteManager routeManager = new RouteManager();
        public RouteManager getRouteManager()
        {
            if (routeManager.IsDisposed)
            {
                routeManager = new RouteManager();
            }
            return routeManager;
        }

        CoachAdd coachAdd = new CoachAdd();
        public CoachAdd getCoachAdd()
        {
            if (coachAdd.IsDisposed)
            {
                coachAdd = new CoachAdd();
            }
            return coachAdd;
        }

        CoachEdit coachEdit = new CoachEdit();
        public CoachEdit getCoachEdit()
        {
            if (coachEdit.IsDisposed)
            {
                coachEdit = new CoachEdit();
            }
            return coachEdit;
        }

        CoachManager coachManager = new CoachManager();
        public CoachManager getCoachManager()
        {
            if (coachManager.IsDisposed)
            {
                coachManager = new CoachManager();
            }
            return coachManager;
        }

        SeatingAllocator seatingAllocator = new SeatingAllocator();
        public SeatingAllocator getSeatingAllocator()
        {
            if (seatingAllocator.IsDisposed)
            {
                seatingAllocator = new SeatingAllocator();
            }
            return seatingAllocator;
        }

        private WindowsHandler()
        {
        }

        public static WindowsHandler getInstance()
        {
            return instance;
        }
    }
}
