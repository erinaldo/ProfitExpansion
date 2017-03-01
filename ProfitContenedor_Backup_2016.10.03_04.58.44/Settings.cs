﻿namespace ProfitContenedor.Properties {
    
    
    // Esta clase le permite controlar eventos específicos en la clase de configuración:
    //  El evento SettingChanging se desencadena antes de cambiar un valor de configuración.
    //  El evento PropertyChanged se desencadena después de cambiar el valor de configuración.
    //  El evento SettingsLoaded se desencadena después de cargar los valores de configuración.
    //  El evento SettingsSaving se desencadena antes de guardar los valores de configuración.
    internal sealed partial class Settings {
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // Agregar código para administrar aquí el evento SettingChangingEvent.
        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            // Agregar código para administrar aquí el evento SettingsSaving.
        }
    }
}
