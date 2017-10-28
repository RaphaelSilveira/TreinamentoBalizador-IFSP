using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TreinamentoBalizador_IFSP.Models;
using TreinamentoBalizador_IFSP.Communication;

namespace TreinamentoBalizador_IFSP.Services
{
    class CommunicationService
    {
        private const String SUCCESS_MOVEMENT = "Movimento executado com sucesso";
        private const String FAILED_MOVEMENT = "O movimento não foi executado corretamente";
        private const String SUCCESS_SAVED = "Movimento salvo com sucesso";
        private const String FAILED_SAVED = "Não foi possível salvar movimento";

        MovementServerCommunication communication = new MovementServerCommunication();

        public void Communicate(FormatedCoordinatesModel formatedCoordinates, Boolean trainingFile)
        {

            if (trainingFile)
            {
                bool saveSuccess = communication.SaveMovement(formatedCoordinates);

                if (saveSuccess)
                {
                    MessageBox.Show(SUCCESS_SAVED, "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(FAILED_SAVED, "Ops!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                bool verifySuccess = communication.VerifyMovement(formatedCoordinates);

                if (verifySuccess)
                {
                    MessageBox.Show(SUCCESS_MOVEMENT, "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(FAILED_MOVEMENT, "Ops!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool CommunicateExam(FormatedCoordinatesModel formatedCoordinates)
        {
            return communication.VerifyMovement(formatedCoordinates);
        }
    }
}
