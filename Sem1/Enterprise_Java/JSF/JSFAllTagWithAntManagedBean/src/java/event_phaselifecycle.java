/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
import javax.faces.event.*;
/**
 *
 * @author Planet
 */
public class event_phaselifecycle implements PhaseListener{

    @Override
    public void afterPhase(PhaseEvent pe) {
        System.err.println("After :: "+pe.getPhaseId());
    }

    @Override
    public void beforePhase(PhaseEvent pe) {
        System.err.println("Before :: "+pe.getPhaseId());
    }

    @Override
    public PhaseId getPhaseId() {
        return PhaseId.ANY_PHASE;
    }
    
    
}
