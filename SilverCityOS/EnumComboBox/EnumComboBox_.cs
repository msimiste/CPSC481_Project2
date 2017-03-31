﻿using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace EnumComboBox
{
    public class EnumComboBox_ : ComboBox
    {
        /// <summary>
        /// The enum type property
        /// </summary>
        public static readonly DependencyProperty EnumTypeProperty = DependencyProperty.Register("EnumType", typeof(Type), typeof(EnumComboBox_), new PropertyMetadata(EnumTypeChanged));

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumComboBox_"/> class.
        /// </summary>
        public EnumComboBox_()
        {
            this.IsEditable = false;
            this.DisplayMemberPath = "Description";
            this.SelectedValuePath = "Value";
        }

        /// <summary>
        /// Gets or sets the type of the enum.
        /// </summary>
        /// <value>
        /// The type of the enum.
        /// </value>
        public Type EnumType
        {
            get { return (Type)GetValue(EnumTypeProperty); }
            set { SetValue(EnumTypeProperty, value); }
        }

        /// <summary>
        /// The enum type changed.
        /// </summary>
        /// <param name="d">The d.</param>
        /// <param name="e">The <see cref="DependencyPropertyChangedEventArgs"/> instance containing the event data.</param>
        private static void EnumTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var comboBox = (EnumComboBox_)d;

            Type generic = typeof(EnumMember<>).MakeGenericType(comboBox.EnumType);
            object instance = Activator.CreateInstance(generic);
            MethodInfo method = instance.GetType().GetMethod("ConvertToList");
            dynamic itemsource = method.Invoke(instance, null);
            comboBox.ItemsSource = itemsource;
        }
    }
}
