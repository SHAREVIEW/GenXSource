/*
 * $Id: AbstractComponentAddon.java,v 1.10 2007/11/17 03:20:32 kschaefe Exp $
 *
 * Copyright 2004 Sun Microsystems, Inc., 4150 Network Circle,
 * Santa Clara, California 95054, U.S.A. All rights reserved.
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 * 
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
 */
package n2f.mediauploader.common.plaf;

import java.util.ArrayList;
import java.util.List;

import javax.swing.UIManager;

import n2f.mediauploader.common.plaf.linux.LinuxLookAndFeelAddons;
import n2f.mediauploader.common.plaf.macosx.MacOSXLookAndFeelAddons;
import n2f.mediauploader.common.plaf.metal.MetalLookAndFeelAddons;
import n2f.mediauploader.common.plaf.motif.MotifLookAndFeelAddons;
import n2f.mediauploader.common.plaf.nimbus.NimbusLookAndFeelAddons;
import n2f.mediauploader.common.plaf.windows.WindowsLookAndFeelAddons;

/**
 * Ease the work of creating an addon for a component.<br>
 * 
 * @author <a href="mailto:fred@L2FProd.com">Frederic Lavigne</a>
 */
public abstract class AbstractComponentAddon implements ComponentAddon {

  private String name;

  protected AbstractComponentAddon(String name) {
    this.name = name;
  }

  public final String getName() {
    return name;
  }

  public void initialize(LookAndFeelAddons addon) {
    addon.loadDefaults(getDefaults(addon));
  }

  public void uninitialize(LookAndFeelAddons addon) {
    // commented after Issue 446. Maybe addon should keep track of its
    // added defaults to correctly remove them on uninitialize
    // addon.unloadDefaults(getDefaults(addon));
  }

  /**
   * Adds default key/value pairs to the given list.
   * 
   * @param addon
   * @param defaults
   */
  protected void addBasicDefaults(LookAndFeelAddons addon, List<Object> defaults) {
  }

  /**
   * Default implementation calls {@link #addBasicDefaults(LookAndFeelAddons, List)}
   * 
   * @param addon
   * @param defaults
   */
  protected void addMacDefaults(LookAndFeelAddons addon, List<Object> defaults) {
    addBasicDefaults(addon, defaults);
  }

  /**
   * Default implementation calls {@link #addBasicDefaults(LookAndFeelAddons, List)}
   * 
   * @param addon
   * @param defaults
   */
  protected void addMetalDefaults(LookAndFeelAddons addon, List<Object> defaults) {
    addBasicDefaults(addon, defaults);
  }

  /**
   * Default implementation calls {@link #addBasicDefaults(LookAndFeelAddons, List)}
   * 
   * @param addon
   * @param defaults
   */
  protected void addMotifDefaults(LookAndFeelAddons addon, List<Object> defaults) {
    addBasicDefaults(addon, defaults);
  }

  /**
   * Default implementation calls {@link #addBasicDefaults(LookAndFeelAddons, List)}
   * 
   * @param addon
   * @param defaults
   */
  protected void addWindowsDefaults(LookAndFeelAddons addon, List<Object> defaults) {
    addBasicDefaults(addon, defaults);
  }

  /**
   * Default implementation calls {@link #addBasicDefaults(LookAndFeelAddons, List)}
   * 
   * @param addon
   * @param defaults
   */
   protected void addLinuxDefaults(LookAndFeelAddons addon, List<Object> defaults) {
     addBasicDefaults(addon, defaults);
   }
 
  /**
   * Default implementation calls {@link #addBasicDefaults(LookAndFeelAddons, List)}
   * 
   * @param addon
   * @param defaults
   */
   protected void addNimbusDefaults(LookAndFeelAddons addon, List<Object> defaults) {
     addBasicDefaults(addon, defaults);
   }
 
   /**
   * Gets the defaults for the given addon.
   * 
   * Based on the addon, it calls
   * {@link #addMacDefaults(LookAndFeelAddons, List)} if isMac()
   * or
   * {@link #addMetalDefaults(LookAndFeelAddons, List)} if isMetal()
   * or
   * {@link #addMotifDefaults(LookAndFeelAddons, List)} if isMotif()
   * or
   * {@link #addWindowsDefaults(LookAndFeelAddons, List)} if isWindows()
   * or
   * {@link #addBasicDefaults(LookAndFeelAddons, List)} if none of the above was called.
   * @param addon
   * @return an array of key/value pairs. For example:
   * <pre>
   * Object[] uiDefaults = {
   *   "Font", new Font("Dialog", Font.BOLD, 12),
   *   "Color", Color.red,
   *   "five", new Integer(5)
   * };
   * </pre>
   */
  private Object[] getDefaults(LookAndFeelAddons addon) {
    List<Object> defaults = new ArrayList<Object>();
    if (isWindows(addon)) {
      addWindowsDefaults(addon, defaults);
    } else if (isMetal(addon)) {
      addMetalDefaults(addon, defaults);
    } else if (isMac(addon)) {
      addMacDefaults(addon, defaults);
    } else if (isMotif(addon)) {
      addMotifDefaults(addon, defaults);
    } else if (isLinux(addon)) {
      addLinuxDefaults(addon, defaults);
    } else if (isNimbus(addon)) {
      addNimbusDefaults(addon, defaults);
    } else {
      // at least add basic defaults
      addBasicDefaults(addon, defaults);
    }
    return defaults.toArray();
  }

  //
  // Helper methods to make ComponentAddon developer life easier
  //

  /**
   * @return true if the addon is the Windows addon or its subclasses
   */
  protected boolean isWindows(LookAndFeelAddons addon) {
    return addon instanceof WindowsLookAndFeelAddons;
  }

  /**
   * @return true if the addon is the Metal addon or its subclasses
   */
  protected boolean isMetal(LookAndFeelAddons addon) {
    return addon instanceof MetalLookAndFeelAddons;
  }

  /**
   * @return true if the addon is the Mac OS X addon or its subclasses
   */
  protected boolean isMac(LookAndFeelAddons addon) {
    return addon instanceof MacOSXLookAndFeelAddons;
  }

  /**
   * @return true if the addon is the Motif addon or its subclasses
   */
  protected boolean isMotif(LookAndFeelAddons addon) {
    return addon instanceof MotifLookAndFeelAddons;
  }

  /**
   * @return true if the current look and feel is Linux
   */
  protected boolean isLinux(LookAndFeelAddons addon) {
      return addon instanceof LinuxLookAndFeelAddons;
  }
  
  /**
   * @return true if the current look and feel is Nimbus
   */
  protected boolean isNimbus(LookAndFeelAddons addon) {
      return addon instanceof NimbusLookAndFeelAddons;
  }
  
  /**
   * @return true if the current look and feel is one of JGoodies Plastic l&fs
   */
  protected boolean isPlastic() {
    return UIManager.getLookAndFeel().getClass().getName().contains("Plastic");
  }

  /**
   * @return true if the current look and feel is Synth l&f
   */
  protected boolean isSynth() {
    return UIManager.getLookAndFeel().getClass().getName().contains("ynth");
  }

}
