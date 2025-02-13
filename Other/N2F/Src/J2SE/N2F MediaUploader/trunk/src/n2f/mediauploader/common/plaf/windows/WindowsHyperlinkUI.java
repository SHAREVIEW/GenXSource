/**
 * $Id: WindowsHyperlinkUI.java,v 1.4 2007/10/29 17:13:57 kschaefe Exp $
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
package n2f.mediauploader.common.plaf.windows;

import java.awt.Graphics;

import javax.swing.AbstractButton;
import javax.swing.BorderFactory;
import javax.swing.JComponent;
import javax.swing.plaf.BorderUIResource;
import javax.swing.plaf.ComponentUI;
import javax.swing.plaf.UIResource;

import n2f.mediauploader.common.plaf.basic.BasicHyperlinkUI;

/**
 * Extends BasicHyperlinkUI and paints the text with an offset when mouse
 * pressed.<br>
 */
public class WindowsHyperlinkUI extends BasicHyperlinkUI {

  public static ComponentUI createUI(JComponent c) {
    return new WindowsHyperlinkUI();
  }
  
  /**
   * {@inheritDoc}
   */
    @Override
  protected void paintButtonPressed(Graphics g, AbstractButton b) {
    setTextShiftOffset();
  }
  
    /**
     * {@inheritDoc}
     */
    @Override
    protected void installDefaults(AbstractButton b) {
        super.installDefaults(b);
        if (b.getBorder() == null || b.getBorder() instanceof UIResource) {
            b.setBorder(new BorderUIResource(BorderFactory.createEmptyBorder(0, 1, 0, 0)));
        }
    }
}
